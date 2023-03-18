CREATE TABLE [dbo].[Table_LoanCal] (
    [CustomerId]     VARCHAR (50) NOT NULL,
    [CustomerName]   VARCHAR (50) NULL,
    [interest]       FLOAT (53)   NULL,
    [principal]      MONEY        NULL,
    [years]          INT          NULL,
    [monthlyPayment] MONEY        NULL,
    [monthlyIncome]  MONEY        NULL,
    [eligibility]    VARCHAR (50) NULL,
    [typeofLoan] VARCHAR(50) NULL, 
    CONSTRAINT [PK_Table_LoanCal] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

