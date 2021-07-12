using SimpleMigrations;
using System;

namespace Facturacion.Migrations
{
    [Migration(1, "Create Setup Tables")]
    public class M001_CreateTables : Migration
    {
        protected override void Down() => throw new NotImplementedException();

        protected override void Up() => Execute(@"
            CREATE TABLE Users (
                Id           INTEGER PRIMARY KEY AUTOINCREMENT,
                Username     TEXT            NOT NULL UNIQUE,
                Password     TEXT            NOT NULL,
                IsAdmin      TINYINT         NOT NULL DEFAULT (0),
                Active       TINYINT         NOT NULL DEFAULT (1),
                CreatedBy    INT             NOT NULL,
                CreatedOn    DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                ModifiedBy   INT             NOT NULL,
                ModifiedOn   DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                CONSTRAINT fk_User_CreatedBy  FOREIGN KEY (CreatedBy)  REFERENCES Users(CreatedBy),
                CONSTRAINT fk_User_ModifiedBy FOREIGN KEY (ModifiedBy) REFERENCES Users(ModifiedBy)
            );
            
            INSERT INTO Users
              (Username, Password, IsAdmin, CreatedBy, ModifiedBy)
            VALUES
              ('admin', '123456', 1, 1, 1);

            CREATE TABLE Customers (
                Id           INTEGER PRIMARY KEY AUTOINCREMENT,
                FullName     TEXT            NOT NULL,
                GvmtId       TEXT            NOT NULL UNIQUE,
                Active       TINYINT         NOT NULL DEFAULT (1),
                CreatedBy    INT             NOT NULL,
                CreatedOn    DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                ModifiedBy   INT             NOT NULL,
                ModifiedOn   DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                CONSTRAINT fk_Customer_CreatedBy  FOREIGN KEY (CreatedBy)  REFERENCES Users(CreatedBy),
                CONSTRAINT fk_Customer_ModifiedBy FOREIGN KEY (ModifiedBy) REFERENCES Users(ModifiedBy)
            );

            CREATE TABLE Sellers (
                Id           INTEGER PRIMARY KEY AUTOINCREMENT,
                FullName     TEXT            NOT NULL,
                Commission   DOUBLE          NOT NULL,
                Active       TINYINT         NOT NULL DEFAULT (1),
                CreatedBy    INT             NOT NULL,
                CreatedOn    DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                ModifiedBy   INT             NOT NULL,
                ModifiedOn   DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                CONSTRAINT fk_Seller_CreatedBy  FOREIGN KEY (CreatedBy)  REFERENCES Users(CreatedBy),
                CONSTRAINT fk_Seller_ModifiedBy FOREIGN KEY (ModifiedBy) REFERENCES Users(ModifiedBy),
                CONSTRAINT chk_Seller_Commission CHECK (Commission >= 0.00)
            );

            CREATE TABLE Items (
                Id           INTEGER PRIMARY KEY AUTOINCREMENT,
                Description  TEXT            NOT NULL,
                Cost         DOUBLE          NOT NULL,
                Price        DOUBLE          NOT NULL,
                Stock        INT             NOT NULL,
                Active       TINYINT         NOT NULL DEFAULT (1),
                CreatedBy    INT             NOT NULL,
                CreatedOn    DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                ModifiedBy   INT             NOT NULL,
                ModifiedOn   DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                CONSTRAINT fk_Item_CreatedBy  FOREIGN KEY (CreatedBy)  REFERENCES Users(CreatedBy),
                CONSTRAINT fk_Item_ModifiedBy FOREIGN KEY (ModifiedBy) REFERENCES Users(ModifiedBy),
                CONSTRAINT chk_Item_Stock CHECK (Stock >= 0),
                CONSTRAINT chk_Item_Price CHECK (Price >= 0.00),
                CONSTRAINT chk_Item_Cost  CHECK (Cost >= 0.00)
            );

            CREATE TABLE PaymentConditions (
                Id           INTEGER PRIMARY KEY AUTOINCREMENT,
                Description  TEXT            NOT NULL,
                Days         INT             NOT NULL,
                Active       TINYINT         NOT NULL DEFAULT (1),
                CreatedBy    INT             NOT NULL,
                CreatedOn    DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                ModifiedBy   INT             NOT NULL,
                ModifiedOn   DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                CONSTRAINT fk_PmtConds_CreatedBy  FOREIGN KEY (CreatedBy)  REFERENCES Users(CreatedBy),
                CONSTRAINT fk_PmtConds_ModifiedBy FOREIGN KEY (ModifiedBy) REFERENCES Users(ModifiedBy),
                CONSTRAINT chk_PmtConds_Days CHECK (Days >= 0)
            );

            CREATE TABLE PaymentMethods (
                Id            INTEGER PRIMARY KEY AUTOINCREMENT,
                Description   TEXT            NOT NULL,
                RequiresInput TINYINT         NOT NULL DEFAULT (0),
                InputTitle    TEXT            NOT NULL,
                Active        TINYINT         NOT NULL DEFAULT (1),
                CreatedBy     INT             NOT NULL,
                CreatedOn     DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                ModifiedBy    INT             NOT NULL,
                ModifiedOn    DATETIME        NOT NULL DEFAULT (DATETIME('now'))
            );

            CREATE TABLE Invoices (
                Id                 INTEGER PRIMARY KEY AUTOINCREMENT,
                SellerId           INTEGER         NOT NULL,
                CustomerId         INTEGER         NOT NULL,
                PaymentMethodId    INTEGER         NOT NULL,
                PaymentInputValue  TEXT            NULL     DEFAULT (NULL),
                Comments           TEXT            NULL     DEFAULT (NULL),
                ProcessedOn        DATETIME        NOT NULL,
                CreatedBy          INT             NOT NULL,
                CreatedOn          DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                ModifiedBy         INT             NOT NULL,
                ModifiedOn         DATETIME        NOT NULL DEFAULT (DATETIME('now')),
                CONSTRAINT fk_Invoice_CreatedBy  FOREIGN KEY (CreatedBy)  REFERENCES Users(CreatedBy),
                CONSTRAINT fk_Invoice_ModifiedBy FOREIGN KEY (ModifiedBy) REFERENCES Users(ModifiedBy),
                CONSTRAINT fk_Invoice_SellerId   FOREIGN KEY (SellerId) REFERENCES Sellers(Id),
                CONSTRAINT fk_Invoice_CustomerId FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
            );

            CREATE TABLE InvoiceDetails (
                InvoiceId    INTEGER NOT NULL,
                Entry        INTEGER NOT NULL DEFAULT (1),
                ItemId       INTEGER NOT NULL,
                Description  TEXT    NOT NULL,
                Price        DOUBLE  NOT NULL,
                Amount       INTEGER NOT NULL,
                CONSTRAINT fk_InvDetails_InvoiceId FOREIGN KEY (InvoiceId) REFERENCES Invoices(Id),
                CONSTRAINT fk_InvDetails_ItemId FOREIGN KEY (ItemId) REFERENCES Items(Id),
                CONSTRAINT chk_InvDetails_Amount CHECK (Amount >= 1),
                CONSTRAINT chk_InvDetails_Price CHECK (Price >= 0.00)
            );
        ");
    }
}
