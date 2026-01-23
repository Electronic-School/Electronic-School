USE SchoolManagementDB
GO
 
CREATE TABLE StudentLevel( 
	LevelId INT IDENTITY(1,1) NOT NULL,
	-- levelname will be a dropdownlist to show ( «·’› «·«Ê· «·√”«”Ì° «·’› «·À«‰Ì...)
	LevelName NVARCHAR(50) NOT NULL,
	LevelNumber INT NOT NULL CHECK (LevelNumber between 1 and 12),
	Stage NVARCHAR(20) NOT NULL CHECK (Stage IN (N'«» œ«∆Ì',N'√”«”Ì',N'À«‰ÊÌ'))
);

-- On Students table
ALTER TABLE [dbo].[Students] add LevelId INT NOT NULL; 
GO
ALTER TABLE [dbo].[Students] ADD CONSTRAINT FK_Students_StudentLevel FOREIGN KEY (LevelId) REFERENCES StudentLevel(LevelId);
GO

-- On Curriculum table
-- €Ì—  «”„ «·⁄„Êœ to CurriculumId instead of Id

IF EXISTS (SELECT * FROM sys.columns WHERE Name = N'Id' AND Object_ID = Object_ID(N'[dbo].[Curriculum]'))
BEGIN
    EXEC sp_rename '[dbo].[Curriculum].[Id]', 'CurriculumId', 'COLUMN';
END
GO


ALTER TABLE [dbo].[Curriculum] ADD LevelId INT NOT NULL;
GO
ALTER TABLE [dbo].[Curriculum] ADD CONSTRAINT FK_Curriculum_StudentLevel FOREIGN KEY (LevelId) REFERENCES StudentLevel(LevelId);
GO
ALTER TABLE [dbo].[Curriculum] ADD Semester NVARCHAR(20) NOT NULL;
GO
ALTER TABLE [dbo].[Curriculum] ADD CONSTRAINT CHK_Curriculum_Semester CHECK (Semester IN (N'«· —„ «·√Ê·', N'«· —„ «·À«‰Ì'));
GO