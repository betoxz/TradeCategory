using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Trade.Domain.TradeContext.Enuns;
using Trade.Domain.TradeContext.Intefaces;

namespace Trade.Domain.TradeContext.Entities
{
    public class Trade : ITrade
    {
        public double Value { get; private set; }
        public string ClientSector { get; private set; }

        public Trade(double valor, string clienteSetor)
        {
            this.Value = valor;
            this.ClientSector = clienteSetor;
        }

        public string getCateroria()
        {
            return (this.ClientSector.Equals(SetorEnum.Private.ToString())) ?
                new SetorPrivado().getCategoria(this.Value)
                : new SetorPublico().getCategoria(this.Value);
        }
    }
}
