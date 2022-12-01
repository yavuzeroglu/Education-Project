USE [master]
GO
/****** Object:  Database [EducationSite]    Script Date: 1.12.2022 14:48:37 ******/
CREATE DATABASE [EducationSite]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EducationSite', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EducationSite.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EducationSite_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EducationSite_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EducationSite] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EducationSite].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EducationSite] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EducationSite] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EducationSite] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EducationSite] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EducationSite] SET ARITHABORT OFF 
GO
ALTER DATABASE [EducationSite] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EducationSite] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EducationSite] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EducationSite] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EducationSite] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EducationSite] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EducationSite] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EducationSite] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EducationSite] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EducationSite] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EducationSite] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EducationSite] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EducationSite] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EducationSite] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EducationSite] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EducationSite] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [EducationSite] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EducationSite] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EducationSite] SET  MULTI_USER 
GO
ALTER DATABASE [EducationSite] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EducationSite] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EducationSite] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EducationSite] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EducationSite] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EducationSite] SET QUERY_STORE = OFF
GO
USE [EducationSite]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1.12.2022 14:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 1.12.2022 14:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[ExamId] [int] NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseStudent]    Script Date: 1.12.2022 14:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseStudent](
	[CoursesId] [int] NOT NULL,
	[StudentsId] [int] NOT NULL,
 CONSTRAINT [PK_CourseStudent] PRIMARY KEY CLUSTERED 
(
	[CoursesId] ASC,
	[StudentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentFileSubject]    Script Date: 1.12.2022 14:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentFileSubject](
	[DocumentFilesId] [int] NOT NULL,
	[SubjectsId] [int] NOT NULL,
 CONSTRAINT [PK_DocumentFileSubject] PRIMARY KEY CLUSTERED 
(
	[DocumentFilesId] ASC,
	[SubjectsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exams]    Script Date: 1.12.2022 14:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SubjectId] [int] NOT NULL,
 CONSTRAINT [PK_Exams] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Files]    Script Date: 1.12.2022 14:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Files](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [nvarchar](max) NOT NULL,
	[Path] [nvarchar](max) NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Files] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lessons]    Script Date: 1.12.2022 14:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lessons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CourseId] [int] NULL,
 CONSTRAINT [PK_Lessons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 1.12.2022 14:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExamId] [int] NOT NULL,
	[ExamQuestion] [nvarchar](max) NOT NULL,
	[CorrectAnswer] [nvarchar](max) NOT NULL,
	[WrongAnswers] [nvarchar](max) NOT NULL,
	[TraineeAnswer] [nvarchar](max) NULL,
	[IsCorrect] [bit] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 1.12.2022 14:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Phone] [nchar](14) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 1.12.2022 14:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[LessonId] [int] NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectSubjectImageFile]    Script Date: 1.12.2022 14:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectSubjectImageFile](
	[SubjectImageFilesId] [int] NOT NULL,
	[SubjectsId] [int] NOT NULL,
 CONSTRAINT [PK_SubjectSubjectImageFile] PRIMARY KEY CLUSTERED 
(
	[SubjectImageFilesId] ASC,
	[SubjectsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221121144759_mig_1', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221126133100_mig_2', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221126145000_mig_3', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221130093428_mig_4', N'6.0.5')
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([Id], [Name], [IsActive], [ExamId]) VALUES (1, N'.Net Core 6', 0, NULL)
INSERT [dbo].[Courses] ([Id], [Name], [IsActive], [ExamId]) VALUES (8, N'React', 0, NULL)
INSERT [dbo].[Courses] ([Id], [Name], [IsActive], [ExamId]) VALUES (9, N'Svelte', 0, NULL)
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Exams] ON 

INSERT [dbo].[Exams] ([Id], [SubjectId]) VALUES (1, 1)
SET IDENTITY_INSERT [dbo].[Exams] OFF
GO
SET IDENTITY_INSERT [dbo].[Files] ON 

INSERT [dbo].[Files] ([Id], [FileName], [Path], [Discriminator]) VALUES (6, N'Sistoskopi-rt-Seti-1.png', N'C:\Users\fatih\Desktop\egitim-proje\Education-Project\Presentation\Education.API\wwwroot\subject-images\Files', N'SubjectImageFile')
INSERT [dbo].[Files] ([Id], [FileName], [Path], [Discriminator]) VALUES (7, N'Perk-tan-rt-Seti-1.png', N'C:\Users\fatih\Desktop\egitim-proje\Education-Project\Presentation\Education.API\wwwroot\subject-images\Files', N'SubjectImageFile')
INSERT [dbo].[Files] ([Id], [FileName], [Path], [Discriminator]) VALUES (8, N'Perkütan Örtü Seti-1.png', N'C:\Users\fatih\Desktop\egitim-proje\Education-Project\Presentation\Education.API\wwwroot\subject-images\Files', N'SubjectImageFile')
INSERT [dbo].[Files] ([Id], [FileName], [Path], [Discriminator]) VALUES (9, N'2-Cepli-Enstr-mental-Po-1-1.jpg', N'C:\Users\fatih\Desktop\egitim-proje\Education-Project\Presentation\Education.API\wwwroot\subject-images\Files', N'SubjectImageFile')
SET IDENTITY_INSERT [dbo].[Files] OFF
GO
SET IDENTITY_INSERT [dbo].[Lessons] ON 

INSERT [dbo].[Lessons] ([Id], [Name], [IsActive], [CourseId]) VALUES (1, N'Kayıt1', 0, 1)
INSERT [dbo].[Lessons] ([Id], [Name], [IsActive], [CourseId]) VALUES (7, N'Deneme React', 0, 8)
SET IDENTITY_INSERT [dbo].[Lessons] OFF
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([Id], [ExamId], [ExamQuestion], [CorrectAnswer], [WrongAnswers], [TraineeAnswer], [IsCorrect], [IsActive]) VALUES (4, 1, N'Example Question 1', N'Example Correct Answer 1', N'Example Wrong Answer 1', N'string', 1, 0)
INSERT [dbo].[Questions] ([Id], [ExamId], [ExamQuestion], [CorrectAnswer], [WrongAnswers], [TraineeAnswer], [IsCorrect], [IsActive]) VALUES (5, 1, N'Example Question 1', N'Example Correct Answer 1', N'Example Wrong Answer 1', NULL, NULL, 0)
INSERT [dbo].[Questions] ([Id], [ExamId], [ExamQuestion], [CorrectAnswer], [WrongAnswers], [TraineeAnswer], [IsCorrect], [IsActive]) VALUES (6, 1, N'Example Question 2', N'Example Correct Answer 2', N'Example Wrong Answer 2', NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Name], [Surname], [Email], [Password], [Phone], [IsActive]) VALUES (1, N'test1', N'test1', N'test1@mail.com', N'test', N'12345678901   ', 0)
INSERT [dbo].[Students] ([Id], [Name], [Surname], [Email], [Password], [Phone], [IsActive]) VALUES (2, N'test2', N'test2', N'test2@mail.com', N'test', N'12345678901   ', 0)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([Id], [Name], [IsActive], [LessonId]) VALUES (1, N'Degiskenler v2', 0, 1)
INSERT [dbo].[Subjects] ([Id], [Name], [IsActive], [LessonId]) VALUES (2, N'test', 0, 7)
SET IDENTITY_INSERT [dbo].[Subjects] OFF
GO
INSERT [dbo].[SubjectSubjectImageFile] ([SubjectImageFilesId], [SubjectsId]) VALUES (7, 1)
INSERT [dbo].[SubjectSubjectImageFile] ([SubjectImageFilesId], [SubjectsId]) VALUES (8, 1)
INSERT [dbo].[SubjectSubjectImageFile] ([SubjectImageFilesId], [SubjectsId]) VALUES (9, 1)
INSERT [dbo].[SubjectSubjectImageFile] ([SubjectImageFilesId], [SubjectsId]) VALUES (6, 2)
GO
/****** Object:  Index [IX_Courses_ExamId]    Script Date: 1.12.2022 14:48:37 ******/
CREATE NONCLUSTERED INDEX [IX_Courses_ExamId] ON [dbo].[Courses]
(
	[ExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CourseStudent_StudentsId]    Script Date: 1.12.2022 14:48:37 ******/
CREATE NONCLUSTERED INDEX [IX_CourseStudent_StudentsId] ON [dbo].[CourseStudent]
(
	[StudentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DocumentFileSubject_SubjectsId]    Script Date: 1.12.2022 14:48:37 ******/
CREATE NONCLUSTERED INDEX [IX_DocumentFileSubject_SubjectsId] ON [dbo].[DocumentFileSubject]
(
	[SubjectsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Exams_SubjectId]    Script Date: 1.12.2022 14:48:37 ******/
CREATE NONCLUSTERED INDEX [IX_Exams_SubjectId] ON [dbo].[Exams]
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Lessons_CourseId]    Script Date: 1.12.2022 14:48:37 ******/
CREATE NONCLUSTERED INDEX [IX_Lessons_CourseId] ON [dbo].[Lessons]
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Questions_ExamId]    Script Date: 1.12.2022 14:48:37 ******/
CREATE NONCLUSTERED INDEX [IX_Questions_ExamId] ON [dbo].[Questions]
(
	[ExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Subjects_LessonId]    Script Date: 1.12.2022 14:48:37 ******/
CREATE NONCLUSTERED INDEX [IX_Subjects_LessonId] ON [dbo].[Subjects]
(
	[LessonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SubjectSubjectImageFile_SubjectsId]    Script Date: 1.12.2022 14:48:37 ******/
CREATE NONCLUSTERED INDEX [IX_SubjectSubjectImageFile_SubjectsId] ON [dbo].[SubjectSubjectImageFile]
(
	[SubjectsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Questions] ADD  DEFAULT ((0)) FOR [ExamId]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Exams_ExamId] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exams] ([Id])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Exams_ExamId]
GO
ALTER TABLE [dbo].[CourseStudent]  WITH CHECK ADD  CONSTRAINT [FK_CourseStudent_Courses_CoursesId] FOREIGN KEY([CoursesId])
REFERENCES [dbo].[Courses] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseStudent] CHECK CONSTRAINT [FK_CourseStudent_Courses_CoursesId]
GO
ALTER TABLE [dbo].[CourseStudent]  WITH CHECK ADD  CONSTRAINT [FK_CourseStudent_Students_StudentsId] FOREIGN KEY([StudentsId])
REFERENCES [dbo].[Students] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseStudent] CHECK CONSTRAINT [FK_CourseStudent_Students_StudentsId]
GO
ALTER TABLE [dbo].[DocumentFileSubject]  WITH CHECK ADD  CONSTRAINT [FK_DocumentFileSubject_Files_DocumentFilesId] FOREIGN KEY([DocumentFilesId])
REFERENCES [dbo].[Files] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DocumentFileSubject] CHECK CONSTRAINT [FK_DocumentFileSubject_Files_DocumentFilesId]
GO
ALTER TABLE [dbo].[DocumentFileSubject]  WITH CHECK ADD  CONSTRAINT [FK_DocumentFileSubject_Subjects_SubjectsId] FOREIGN KEY([SubjectsId])
REFERENCES [dbo].[Subjects] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DocumentFileSubject] CHECK CONSTRAINT [FK_DocumentFileSubject_Subjects_SubjectsId]
GO
ALTER TABLE [dbo].[Exams]  WITH CHECK ADD  CONSTRAINT [FK_Exams_Subjects_SubjectId] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Exams] CHECK CONSTRAINT [FK_Exams_Subjects_SubjectId]
GO
ALTER TABLE [dbo].[Lessons]  WITH CHECK ADD  CONSTRAINT [FK_Lessons_Courses_CourseId] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([Id])
GO
ALTER TABLE [dbo].[Lessons] CHECK CONSTRAINT [FK_Lessons_Courses_CourseId]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_Questions_Exams_ExamId] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exams] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_Questions_Exams_ExamId]
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD  CONSTRAINT [FK_Subjects_Lessons_LessonId] FOREIGN KEY([LessonId])
REFERENCES [dbo].[Lessons] ([Id])
GO
ALTER TABLE [dbo].[Subjects] CHECK CONSTRAINT [FK_Subjects_Lessons_LessonId]
GO
ALTER TABLE [dbo].[SubjectSubjectImageFile]  WITH CHECK ADD  CONSTRAINT [FK_SubjectSubjectImageFile_Files_SubjectImageFilesId] FOREIGN KEY([SubjectImageFilesId])
REFERENCES [dbo].[Files] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SubjectSubjectImageFile] CHECK CONSTRAINT [FK_SubjectSubjectImageFile_Files_SubjectImageFilesId]
GO
ALTER TABLE [dbo].[SubjectSubjectImageFile]  WITH CHECK ADD  CONSTRAINT [FK_SubjectSubjectImageFile_Subjects_SubjectsId] FOREIGN KEY([SubjectsId])
REFERENCES [dbo].[Subjects] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SubjectSubjectImageFile] CHECK CONSTRAINT [FK_SubjectSubjectImageFile_Subjects_SubjectsId]
GO
USE [master]
GO
ALTER DATABASE [EducationSite] SET  READ_WRITE 
GO
