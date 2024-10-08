SELECT
a.[Id] 
, a.[FirstName] 
, a.[LastName]
FROM [Authors] a
WHERE [a].[Id] = @Id
