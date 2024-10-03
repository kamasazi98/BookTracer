﻿CREATE TABLE IF NOT EXISTS [Books] (
[Id] TEXT PRIMARY KEY,
[Name] TEXT NOT NULL,
[AuthorId] TEXT NOT NULL,
[Rate] INT NOT NULL,
FOREIGN KEY ([AuthorId]) REFERENCES [Authors]([Id]) ON DELETE CASCADE
);