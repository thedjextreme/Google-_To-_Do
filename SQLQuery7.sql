/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[TaskName]
      ,[description]
      ,[priority]
      ,[IsActive]
      ,[StartDate]
      ,[EndDate]
  FROM [Google_To_Do].[dbo].[Task]