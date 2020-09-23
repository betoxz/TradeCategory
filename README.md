# TradeCategory
Question 1. Identify the categories of trades in a bank´s portfolio.

 

A bank has a portfolio of thousands of trades and they need to be categorized.

A trade is a commercial negotiation between a bank and a client.

Each trade has a value that indicates the transaction amount in dollars and a text indicating if the client´s sector is "Public" or "Private". They implement the following interface:

 

interface ITrade

{

    double Value { get; }

    string ClientSector { get; }

}

 

Currently, there are three categories rules:

LOWRISK: Trades with value less than 1,000,000 and client from Public Sector

MEDIUMRISK: Trades with value greater than 1,000,000 and client from Public Sector

HIGHRISK: Trades with value greater than 1,000,000 and client from Private Sector

 

Imagine you receive a list of trades and you need to return a list of categories as below:

input: List<ITrade> portfolio

output: List<string> tradeCategories

 

Example:

Input:

Trade1 {Value = 2000000; ClientSector = "Private"}

Trade2 {Value = 400000; ClientSector = "Public"}

Trade3 {Value = 500000; ClientSector = "Public"}

Trade4 {Value = 3000000; ClientSector = "Public"}

portfolio = {Trade1, Trade2, Trade3, Trade4}

 

Output:

tradeCategories = {"HIGHRISK", "LOWRISK", "LOWRISK", "MEDIUMRISK"}