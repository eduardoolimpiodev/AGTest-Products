EXEC sp_rename N'[Produtos].[Situacao_Produto]', N'SituacaoProduto', N'COLUMN';

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230324035046_Initials', N'2.2.6-servicing-10079');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230324035515_Two', N'2.2.6-servicing-10079');

GO

