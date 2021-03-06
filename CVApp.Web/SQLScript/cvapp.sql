/****** Object:  Database [CV]    Script Date: 2.09.2021 00:09:54 ******/
CREATE DATABASE [CV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\CV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\CV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CV] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CV] SET ARITHABORT OFF 
GO
ALTER DATABASE [CV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CV] SET  MULTI_USER 
GO
ALTER DATABASE [CV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CV] SET QUERY_STORE = OFF
GO
/****** Object:  Table [dbo].[AppUsers]    Script Date: 2.09.2021 00:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[Address] [nvarchar](200) NULL,
	[Email] [nvarchar](50) NULL,
	[ImageUrl] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](30) NULL,
	[ShortDescription] [nvarchar](500) NULL,
	[Language] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Certifications]    Script Date: 2.09.2021 00:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certifications](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NULL,
	[Language] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Educations]    Script Date: 2.09.2021 00:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Educations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[SubTitle] [nvarchar](200) NULL,
	[Description] [nvarchar](500) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[GNO] [decimal](18, 2) NULL,
	[Language] [nvarchar](10) NULL,
 CONSTRAINT [PK__Educatio__3214EC07D55C9F09] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Experiences]    Script Date: 2.09.2021 00:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Experiences](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[SubTitle] [nvarchar](200) NULL,
	[Description] [nvarchar](500) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Language] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Interests]    Script Date: 2.09.2021 00:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Interests](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NULL,
	[Language] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 2.09.2021 00:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[SubTitle] [nvarchar](200) NULL,
	[Description] [nvarchar](max) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[Language] [nvarchar](10) NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skills]    Script Date: 2.09.2021 00:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skills](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NULL,
	[Language] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SocialMediaIcons]    Script Date: 2.09.2021 00:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SocialMediaIcons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Link] [nvarchar](200) NULL,
	[Icon] [nvarchar](100) NULL,
	[Language] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AppUsers] ON 

INSERT [dbo].[AppUsers] ([Id], [FirstName], [LastName], [Address], [Email], [ImageUrl], [PhoneNumber], [UserName], [Password], [ShortDescription], [Language]) VALUES (1, N'Mertcan', N'Karaca', N'İstanbul / TÜRKİYE', N'mertcankrc@gmail.com', N'169d1c4d-5ea7-410f-b10d-197373a9d52c.jpg', N'+905397196296', N'mertcankrc', N'1234567', N'Motive, enerjik, güvenilir, iyi organize olmuş ve tutkulu bir insanım. Yazılım benim için bir zevktir. Yaptığım işte esas amacım müşterinin ihtiyaçlarına gçre mükemmel çözümü bulmaktır. Eğitim geçmişime ve bugüne kadarki iş tecrübeme göre kod yazabilmemin yanı sıra proje iş planları oluşturup yürütebilir, değişen ihtiyaç ve gereksinimlere uygun revize edebilirim.', N'tr-TR')
INSERT [dbo].[AppUsers] ([Id], [FirstName], [LastName], [Address], [Email], [ImageUrl], [PhoneNumber], [UserName], [Password], [ShortDescription], [Language]) VALUES (2, N'Mertcan', N'Karaca', N'İstanbul / TURKEY', N'mertcankrc@gmail.com', NULL, N'+905397196296', N'mertcankrc', NULL, N'I am a motivated, energetic, reliable, well organized and passionate person. It is a pleasure working as a Software Developer. My main goal is always coming with a perfect solution according to customer''s needs. According to my education background and work experience until now, in addition to being able to write code, I could create and execute project work plans, revise as appropriate to meet changing needs and requirements.', N'en-US')
SET IDENTITY_INSERT [dbo].[AppUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[Certifications] ON 

INSERT [dbo].[Certifications] ([Id], [Description], [Language]) VALUES (2, N'lol', N'tr-TR')
INSERT [dbo].[Certifications] ([Id], [Description], [Language]) VALUES (4, N'lol-en', N'en-US')
SET IDENTITY_INSERT [dbo].[Certifications] OFF
GO
SET IDENTITY_INSERT [dbo].[Educations] ON 
INSERT [dbo].[Educations] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [GNO], [Language]) VALUES (1, N'Marmara Üniversitesi', N'İngilizce Hazırlık', N'2014 yılında liseyi bitirdikten sonra ingilizcede yeteneklerimi keskinleştirmek için hazırlık okulunda eğitim gördüm.', CAST(N'2014-09-15' AS Date), CAST(N'2015-06-19' AS Date), 0, N'tr-TR')
INSERT [dbo].[Educations] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [GNO], [Language]) VALUES (2, N'Marmara University', N'English Prep School', N'After graduating from high school in 2014, I started to study in prep school to sharpen my grammar and listening skills.', CAST(N'2014-09-15' AS Date), CAST(N'2015-06-19' AS Date), 0, N'en-US')
INSERT [dbo].[Educations] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [GNO], [Language]) VALUES (3, N'Marmara Üniversitesi', N'Bilgisayar bilimleri ve Mühendisliği', N'Hazırlık okulunu bitirdikten sonra, teorik ve uygulamalı derslerim sayesinde mesleki hayatta ihtiyacım olabilecek temel yetenekleri edindim. Bunların yanında makine öğrenmesi, görüntü işleme ve veri analizi konularıyla ilgilendim.', CAST(N'2015-09-14' AS Date), CAST(N'2019-06-28' AS Date), CAST(2.45 AS Decimal(18, 2)), N'tr-TR')
INSERT [dbo].[Educations] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [GNO], [Language]) VALUES (4, N'Marmara University', N'Computer Sciences and Engineering (B.Sc)', N'After finishing prep school, I gained skills that I am going to need in my professional life via theoretical and practical lectures. Besides these lectures I had an interest in Machine Learning, Image processing and Data Analysis.', CAST(N'2015-09-14' AS Date), CAST(N'2019-06-28' AS Date), CAST(2.45 AS Decimal(18, 2)), N'en-US')
INSERT [dbo].[Educations] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [GNO], [Language]) VALUES (5, N'Marmara Üniversitesi', N'Mühendislik Yönetimi', N'Lisans programından mezun olduğumdan beri kendimi yöneticilik alanında geliştirme planlarım vardı. Bunun için gerekli olan ilk adımı attım.', CAST(N'2021-10-04' AS Date), CAST(N'2022-06-17' AS Date), 0, N'tr-TR')
INSERT [dbo].[Educations] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [GNO], [Language]) VALUES (6, N'Marmara University', N'Engineering Management(M.Sc)', N'After graduating from CSE, I had plans to hone my management skills. First I started with mentoring programs in my company but that was not enough and I took my first step to higher education. .', CAST(N'2021-10-04' AS Date), CAST(N'2022-06-17' AS Date), 0, N'en-US')
SET IDENTITY_INSERT [dbo].[Educations] OFF
GO
SET IDENTITY_INSERT [dbo].[Experiences] ON 

INSERT [dbo].[Experiences] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (4, N'Ziraat Teknoloji A.Ş', N'Stajyer', N'Ziraat teknoloji şirketinde 2017 yazında staj yaptım. Staj sürem boyunca mobil uygulama geliştirme üzerine çalıştım.', CAST(N'2017-07-20T00:00:00.000' AS DateTime), CAST(N'2017-09-20T00:00:00.000' AS DateTime), N'tr-TR')
INSERT [dbo].[Experiences] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (5, N'Marmara Üniversitesi Robotik Kulübü', N'Takım Üyesi', N'Marmara Üniversitesi Robotik Kulübünde 1 yıl boyunca takım üyesi olarak bulundum. Bu süre zarfı içinde üyesi olduğum takımla beraber labirent çözen robot üzerine çalıştım. ', CAST(N'2016-11-11T00:00:00.000' AS DateTime), CAST(N'2017-09-11T00:00:00.000' AS DateTime), N'tr-TR')
INSERT [dbo].[Experiences] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (6, N'Altar', N'Stajyer', N'İkinci stajımı Altar Yazılım Şirketinde yaptım. Staj sürem boyunca .Net MVC ve React JS hakkında tecrübe edinme fırsatı yakaladım.', CAST(N'2018-06-06T00:00:00.000' AS DateTime), CAST(N'2018-08-06T00:00:00.000' AS DateTime), N'tr-TR')
INSERT [dbo].[Experiences] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (7, N'Altar', N'Yazılım Geliştirici', N'Stajımı tamamladıktan sonra Altar Yazılım Şirketinde Yazılım Geliştirici olarak çalışmaya devam ettim. ', CAST(N'2018-08-20T00:00:00.000' AS DateTime), CAST(N'2020-03-20T00:00:00.000' AS DateTime), N'tr-TR')
INSERT [dbo].[Experiences] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (8, N'Otokoç Otomotiv', N'Yazılım Uzmanı & Scrum Master', N'Altar''dan ayrıldıktan sonra iş hayatıma Otokoç Otomotiv''de devam ediyorum. Şu an aktif olarak Otokoç Otomotiv şirketinde Yazılım uzmanı ve Scrum Master olarak çalışıyorum', CAST(N'2020-03-16T00:00:00.000' AS DateTime), NULL, N'tr-TR')
INSERT [dbo].[Experiences] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (9, N'Ziraat Teknoloji A.Ş', N'Intern', N'I did an internship at Ziraat Technology Company in the summer of 2017. During my internship, I worked on mobile application development.', CAST(N'2017-07-20T00:00:00.000' AS DateTime), CAST(N'2017-09-20T00:00:00.000' AS DateTime), N'en-US')
INSERT [dbo].[Experiences] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (10, N'Marmara University Robotic Club', N'Team Member', N'I was a team member at Marmara University Robotics Club for 1 year. During this time, I worked on a maze-solving robot with them.', CAST(N'2016-11-11T00:00:00.000' AS DateTime), CAST(N'2017-09-11T00:00:00.000' AS DateTime), N'en-US')
INSERT [dbo].[Experiences] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (11, N'Altar', N'Intern', N'I did my second internship at Altar Software Company. During my internship, I had the opportunity to experience .Net MVC and React JS.', CAST(N'2018-06-06T00:00:00.000' AS DateTime), CAST(N'2018-08-06T00:00:00.000' AS DateTime), N'en-US')
INSERT [dbo].[Experiences] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (12, N'Altar', N'Software Developer', N'After completing my internship, I continued to work as a Software Developer at Altar Software Company.', CAST(N'2018-08-20T00:00:00.000' AS DateTime), CAST(N'2020-03-13T00:00:00.000' AS DateTime), N'en-US')
INSERT [dbo].[Experiences] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (13, N'Otokoç Automotive', N'Software Specialist & Scrum Master', N'After leaving Altar, I continue my business life at Otokoç Automotive. Currently, I am actively working as a Software Specialist and Scrum Master at Otokoç Otomotiv.', CAST(N'2020-03-16T00:00:00.000' AS DateTime), NULL, N'en-US')
SET IDENTITY_INSERT [dbo].[Experiences] OFF
GO
SET IDENTITY_INSERT [dbo].[Interests] ON 

INSERT [dbo].[Interests] ([Id], [Description], [Language]) VALUES (1, N'Tango', N'tr-TR')
INSERT [dbo].[Interests] ([Id], [Description], [Language]) VALUES (2, N'Müzik', N'tr-TR')
INSERT [dbo].[Interests] ([Id], [Description], [Language]) VALUES (4, N'Sinema', N'tr-TR')
INSERT [dbo].[Interests] ([Id], [Description], [Language]) VALUES (5, N'Tango', N'en-US')
INSERT [dbo].[Interests] ([Id], [Description], [Language]) VALUES (6, N'Music', N'en-US')
INSERT [dbo].[Interests] ([Id], [Description], [Language]) VALUES (7, N'Cinema', N'en-US')
SET IDENTITY_INSERT [dbo].[Interests] OFF
GO
SET IDENTITY_INSERT [dbo].[Projects] ON 

INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (1, N'Maze Solver Robot', N'Marmara University Robotic Club', N'I developed a robot which can solve a maze with my group friends by using arduino . The robot wanders all cells and keep the cells which were wandered in arduino memory. After robot found to finish point, robot calculates shortest path to go start pointand goes to start point. After arrived start point, robot goes to finish point again by using shortest path.', CAST(N'2016-10-10' AS Date), CAST(N'2017-06-06' AS Date), N'en-US')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (2, N'Tango Windows Form', N'Freelance', N'This is a Windows Form project. The project basicly provides users to check attandence to a course, control customer''s monthly payment and basic database operations.', CAST(N'2017-07-07' AS Date), CAST(N'2017-07-07' AS Date), N'en-US')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (3, N'AlarmQuizz Android Application', N'Freelance', N'It is an alarm application. User has to answer five general culture questions for turining off the alarm.', CAST(N'2018-01-10' AS Date), CAST(N'2018-01-19' AS Date), N'en-US')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (4, N'Florence Nightingale', N'Altar', N' I did software development and bugfix within the scope of Florence nighthangle website. While working on this site, I used WCF .NET 4.X, MsSql, IIS and DevExpress.', CAST(N'2018-08-08' AS Date), CAST(N'2020-07-06' AS Date), N'en-US')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (5, N'Atlas Global', N'Altar', N'I worked on the frontend side of the Atlas Global project. I used react js while doing frontend development.', CAST(N'2018-08-20' AS Date), CAST(N'2019-08-20' AS Date), N'en-US')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (6, N'Micro Sites', N'Altar', N'There are template pages in the admin panel. Users can publish the page by giving the desired appearance (Adding, Updating and Deleting) to the articles, links and images on these pages.  I was involved in this project from start to finish.  In this project, I used .NET 4X, MVC, Linq, Entity Framework, Postgresql, Restfull API.', CAST(N'2019-01-01' AS Date), CAST(N'2020-02-01' AS Date), N'en-US')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (7, N'ERP Systems', N'Otokoç Automotive', N'I am developing and bugfixing Otokoç Automotive''s erp systems. I am using .NET 4X, Restfull API, Stored Procedure, Javascript for these systems.', CAST(N'2020-03-16' AS Date), NULL, N'en-US')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (8, N'Otokoç Mobile Module', N'Otokoç Automotive', N'A project we have done for the pandemic process. We developed this project through Otokoç Automotive''s mobile application. We used Xamarin, Restfull API and MsSql for this project.', CAST(N'2020-10-01' AS Date), CAST(N'2021-01-01' AS Date), N'en-US')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (9, N'Marketplace', N'Otokoç Automotive', N'This is a tender site. Users initiate a tender for a product they want to buy and collect offers from suppliers. Converts the appropriate offer into an order. We are using .NET 4X, Javascript, Jquery, MsSql and Restfull API while developing this project.', CAST(N'2020-03-16' AS Date), NULL, N'en-US')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (10, N'B2B E-Commerce', N'Otokoç Automotive', N'It is an E-commerce website that we have just started to develop. Within the scope of this project, we use vue JS on the frontend and .NET 4X Web API, MsSql and Dapper on the backend.', CAST(N'2021-08-01' AS Date), NULL, N'en-US')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (11, N'Personal CV Website', N'Freelance', N'This is the website I created to introduce myself in more detail. You are now inside the website :) While developing this site, I used .Net Core and Dapper in the backend. MVC, Bootstrap is used in the front.', CAST(N'2021-08-01' AS Date), CAST(N'2021-08-30' AS Date), N'en-US')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (12, N'Labirent Çözen Robot', N'Marmara Üniversitesi Robotik Kulübü', N'Grup arkadaşlarımla arduino kullanarak labirent çözebilen bir robot geliştirdim. Robot tüm hücreleri dolaşır ve dolaşan hücreleri arduino hafızasında tutar. Robot bitiş noktasını bulduktan sonra başlangıç ​​noktasına gitmek için en kısa yolu hesaplar ve başlangıç ​​noktasına gider. Başlangıç ​​noktasına geldikten sonra robot en kısa yolu kullanarak tekrar bitiş noktasına gider.', CAST(N'2016-10-10' AS Date), CAST(N'2017-06-06' AS Date), N'tr-TR')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (13, N'Tango Windows Form', N'Freelance', N'Bu bir Windows Form projesidir. Proje temel olarak kullanıcılara bir kursa devamsızlığı ve müşterinin aylık ödemesini kontrol etmeyi sağlar. WinForm ve ADO.NET kullanılarak geliştirilmiştir', CAST(N'2017-07-07' AS Date), CAST(N'2017-07-07' AS Date), N'tr-TR')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (14, N'AlarmQuizz Android Application', N'Freelance', N'Bir alarm uygulamasıdır. Alarm çaldıktan sonra kullanıcıya 5 tane genel kültür sorusu sorar. Eğer kullanıcı sorulara doğru cevap veremezse sorular sıfırlanır ve 5 tane soruyu tekrardan cevaplamak zorunda kalır. 5 Tane soru cevaplanmadan alarm kapanmaz.', CAST(N'2018-01-10' AS Date), CAST(N'2018-01-19' AS Date), N'tr-TR')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (15, N'Florence Nightingale', N'Altar', N'Florence nighthangle web sitesi kapsamında yazılım geliştirme ve bugfix yaptım. Bu site üzerinde çalışırken WCF .NET 4.X, MsSql, IIS ve DevExpress kullandım.', CAST(N'2018-08-08' AS Date), CAST(N'2020-07-06' AS Date), N'tr-TR')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (16, N'Atlas Global', N'Altar', N'Atlas Global projesinin frontend tarafında çalıştım. Frontend geliştirmesi yaparken React JS kullandım.', CAST(N'2018-08-20' AS Date), CAST(N'2019-08-20' AS Date), N'tr-TR')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (17, N'Micro Sites', N'Altar', N'Admin panelinde şablon sayfaları bulunmaktadır. Kullanıcılar bu sayfalardaki makalelere, linklere ve görsellere istedikleri görünümü (Ekleme, Güncelleme ve Silme) vererek sayfayı yayınlayabilirler. Bu projede başından sonuna kadar yer aldım. Bu projemde .NET 4X, MVC, Linq, Entity Framework, Postgresql, Restfull API kullandım.', CAST(N'2019-01-01' AS Date), CAST(N'2020-02-01' AS Date), N'tr-TR')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (18, N'ERP Sistemleri', N'Otokoç Otomotiv', N'Otokoç Otomotiv''in erp sistemlerini geliştiriyor ve hatalarını gideriyorum. Bu sistemler için .NET 4X, Restfull API, Stored Procedure, Javascript kullanıyorum.', CAST(N'2020-03-16' AS Date), NULL, N'tr-TR')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (19, N'Otokoç Mobile Module', N'Otokoç Otomotiv', N'Pandemi süreci için yapmış olduğumuz bir proje. Bu projeyi Otokoç Otomotiv''in mobil uygulaması üzerinden geliştirdik. Bu proje için Xamarin, Restfull API ve MsSql kullandık.', CAST(N'2020-10-01' AS Date), CAST(N'2021-01-01' AS Date), N'tr-TR')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (20, N'Marketplace', N'Otokoç Otomotiv', N'Burası bir ihale sitesidir. Kullanıcılar satın almak istedikleri ürün için ihale başlatır ve tedarikçilerden teklif toplar. Uygun teklifi bir siparişe dönüştürür. Bu projeyi geliştirirken .NET 4X, Javascript, Jquery, MsSql ve Restfull API kullanıyoruz.', CAST(N'2020-03-16' AS Date), NULL, N'tr-TR')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (21, N'B2B E-Commerce', N'Otokoç Otomotiv', N'Yeni geliştirmeye başladığımız bir E-ticaret sitesidir. Bu proje kapsamında frontend''de vue JS, backend''de .NET 4X Web API, MsSql ve Dapper kullanıyoruz', CAST(N'2021-08-01' AS Date), NULL, N'tr-TR')
INSERT [dbo].[Projects] ([Id], [Title], [SubTitle], [Description], [StartDate], [EndDate], [Language]) VALUES (22, N'Kişisel CV Web Sitesi', N'Freelance', N' Kendimi daha detaylı tanıtmak için oluşturduğum web sitesidir. Şu an sitenin içindesiniz :) Bu siteyi geliştirirken arka uçta .Net Core ve Dapper kullandım. Önde MVC, Bootstrap kullanılmıştır.', CAST(N'2021-08-10' AS Date), CAST(N'2021-08-30' AS Date), N'tr-TR')
SET IDENTITY_INSERT [dbo].[Projects] OFF
GO
SET IDENTITY_INSERT [dbo].[Skills] ON 

INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (6, N'ASP.NET MVC', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (7, N'WCF', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (8, N'SQL', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (9, N'PostgreSql', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (10, N'ADO.NET', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (11, N' Entity Framework', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (12, N'HTML', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (13, N'CSS', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (14, N'Javascript', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (15, N'React JS', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (16, N'IIS', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (17, N'Restfull API', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (18, N'Xamarin', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (19, N'Stored Procedure', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (20, N'Vue JS', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (21, N'.NET Core', N'tr-TR')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (22, N'ASP.NET MVC', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (23, N'WCF', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (24, N'SQL', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (25, N'PostgreSql', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (26, N'ADO.NET', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (27, N'Entity Framework', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (28, N'HTML', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (29, N'CSS', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (30, N'Javascript', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (31, N'React JS', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (32, N'IIS', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (33, N'Restfull API', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (34, N'Xamarin', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (35, N'Stored Procedure', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (36, N'Vue JS', N'en-US')
INSERT [dbo].[Skills] ([Id], [Description], [Language]) VALUES (37, N'.NET Core', N'en-US')
SET IDENTITY_INSERT [dbo].[Skills] OFF
GO
SET IDENTITY_INSERT [dbo].[SocialMediaIcons] ON 

INSERT [dbo].[SocialMediaIcons] ([Id], [Link], [Icon], [Language]) VALUES (1, N'https://www.linkedin.com/in/Mertcan-%C3%B6zg%C3%BCn-20566a110/', N'fab fa-linkedin-in', N'tr-TR')
INSERT [dbo].[SocialMediaIcons] ([Id], [Link], [Icon], [Language]) VALUES (3, N'https://github.com/ozgunMertcan', N'fab fa-github', N'tr-TR')
SET IDENTITY_INSERT [dbo].[SocialMediaIcons] OFF
GO
ALTER DATABASE [CV] SET  READ_WRITE 
GO
