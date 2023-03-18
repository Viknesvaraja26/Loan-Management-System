CREATE TABLE [dbo].[View_data] (
    [customerId] VARCHAR (50) NOT NULL,
    [data]       VARCHAR (1000) NULL,
    CONSTRAINT [FK_View_data_Table_LoanCal] FOREIGN KEY ([customerId]) REFERENCES [dbo].[Table_LoanCal] ([CustomerId])
);

