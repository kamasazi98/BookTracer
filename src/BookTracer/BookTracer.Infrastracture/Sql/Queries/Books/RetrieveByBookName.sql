SELECT
b.[Id] 
, b.[Name] 
, b.[AuthorId]
, b.[Rate]
FROM [Books] b
WHERE [a].[Name] = @BookName 
