IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [ContaPagar] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(255) NOT NULL,
    [Valor] decimal(18, 2) NOT NULL DEFAULT 0.0,
    [DataVencimento] datetime2 NOT NULL,
    [DataPagamento] datetime2 NOT NULL,
    [DiasAtrasado] int NOT NULL DEFAULT 0,
    [Multa] decimal(18, 2) NOT NULL DEFAULT 0.0,
    [MultaValor] decimal(18, 2) NOT NULL DEFAULT 0.0,
    [Juros] decimal(18, 2) NOT NULL DEFAULT 0.0,
    [JurosValor] decimal(18, 2) NOT NULL DEFAULT 0.0,
    CONSTRAINT [PK_ContaPagar_Id] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210227172230_Initial', N'3.1.12');

GO

