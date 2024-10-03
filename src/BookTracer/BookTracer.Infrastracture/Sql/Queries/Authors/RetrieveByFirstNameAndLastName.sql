SELECT
a.[Id] 
, a.[FirstName] 
, a.[LastName]
FROM [Authors] a
WHERE [a].[FirstName] = @FirstNameValue AND a.[LastName] = @LastNameValue
