USE [master]
GO
/****** Object:  Database [Censo]    Script Date: 22/11/2021 17:38:43 ******/
CREATE DATABASE [Censo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Censo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Censo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Censo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Censo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Censo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Censo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Censo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Censo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Censo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Censo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Censo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Censo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Censo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Censo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Censo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Censo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Censo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Censo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Censo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Censo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Censo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Censo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Censo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Censo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Censo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Censo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Censo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Censo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Censo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Censo] SET  MULTI_USER 
GO
ALTER DATABASE [Censo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Censo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Censo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Censo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Censo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Censo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Censo] SET QUERY_STORE = OFF
GO
USE [Censo]
GO
/****** Object:  Table [dbo].[Desocupados]    Script Date: 22/11/2021 17:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Desocupados](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Edad] [numeric](18, 0) NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
	[Dni] [numeric](18, 0) NOT NULL,
	[Localidad] [nvarchar](50) NOT NULL,
	[Estado civil] [nvarchar](50) NOT NULL,
	[Cantidad hijos] [numeric](18, 0) NOT NULL,
	[Nivel estudio] [nvarchar](50) NOT NULL,
	[Fecha ultimo trabajo] [datetime] NOT NULL,
	[Ayuda estatal] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiante_Trabajador]    Script Date: 22/11/2021 17:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante_Trabajador](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Edad] [numeric](18, 0) NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
	[Dni] [numeric](18, 0) NOT NULL,
	[Localidad] [nvarchar](50) NOT NULL,
	[Estado civil] [nvarchar](50) NOT NULL,
	[Cantidad hijos] [numeric](18, 0) NOT NULL,
	[Nivel estudio] [nvarchar](50) NOT NULL,
	[Establecimiento] [nvarchar](50) NOT NULL,
	[Nivel] [nvarchar](50) NOT NULL,
	[Carrera] [nvarchar](50) NOT NULL,
	[Trabajo registrado] [bit] NOT NULL,
	[Relacion de dependencia] [bit] NOT NULL,
	[Horas semanales] [numeric](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 22/11/2021 17:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Edad] [numeric](18, 0) NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
	[Dni] [numeric](18, 0) NOT NULL,
	[Localidad] [nvarchar](50) NOT NULL,
	[Estado civil] [nvarchar](50) NOT NULL,
	[Cantidad hijos] [numeric](18, 0) NOT NULL,
	[Nivel estudio] [nvarchar](50) NOT NULL,
	[Establecimiento] [nvarchar](50) NOT NULL,
	[Nivel] [nvarchar](50) NOT NULL,
	[Carrera] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jubilados]    Script Date: 22/11/2021 17:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jubilados](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Edad] [numeric](18, 0) NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
	[Dni] [numeric](18, 0) NOT NULL,
	[Localidad] [nvarchar](50) NOT NULL,
	[Estado civil] [nvarchar](50) NOT NULL,
	[Cantidad hijos] [numeric](18, 0) NOT NULL,
	[Nivel estudio] [nvarchar](50) NOT NULL,
	[anio jubilacion] [numeric](18, 0) NOT NULL,
	[Sigue trabajando] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trabajadores]    Script Date: 22/11/2021 17:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajadores](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Edad] [numeric](18, 0) NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
	[Dni] [numeric](18, 0) NOT NULL,
	[Localidad] [nvarchar](50) NOT NULL,
	[Estado civil] [nvarchar](50) NOT NULL,
	[Cantidad hijos] [numeric](18, 0) NOT NULL,
	[Nivel estudio] [nvarchar](50) NOT NULL,
	[Trabajo registrado] [bit] NOT NULL,
	[Relacion de dependencia] [bit] NOT NULL,
	[Horas semanales] [numeric](18, 0) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Desocupados] ON 
GO
INSERT [dbo].[Desocupados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Fecha ultimo trabajo], [Ayuda estatal]) VALUES (CAST(1 AS Numeric(18, 0)), N'Fernanda', N'Carulo', CAST(38 AS Numeric(18, 0)), N'Femenino', CAST(30036965 AS Numeric(18, 0)), N'Tapiales', N'Casado', CAST(4 AS Numeric(18, 0)), N'Secundario', CAST(N'2020-05-15T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Desocupados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Fecha ultimo trabajo], [Ayuda estatal]) VALUES (CAST(2 AS Numeric(18, 0)), N'Rene', N'Camchatca', CAST(40 AS Numeric(18, 0)), N'Masculino', CAST(27896365 AS Numeric(18, 0)), N'Lomas Del Mirador', N'Casado', CAST(2 AS Numeric(18, 0)), N'Secundario', CAST(N'2021-07-10T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Desocupados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Fecha ultimo trabajo], [Ayuda estatal]) VALUES (CAST(3 AS Numeric(18, 0)), N'Juan', N'Soria', CAST(30 AS Numeric(18, 0)), N'Masculino', CAST(30695852 AS Numeric(18, 0)), N'Ciudadela', N'Soltero', CAST(1 AS Numeric(18, 0)), N'Primario', CAST(N'2020-04-06T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Desocupados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Fecha ultimo trabajo], [Ayuda estatal]) VALUES (CAST(4 AS Numeric(18, 0)), N'Lorenas', N'Rati', CAST(25 AS Numeric(18, 0)), N'Femenino', CAST(38963214 AS Numeric(18, 0)), N'Caseros', N'Soltero', CAST(2 AS Numeric(18, 0)), N'Primario', CAST(N'2019-02-20T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Desocupados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Fecha ultimo trabajo], [Ayuda estatal]) VALUES (CAST(5 AS Numeric(18, 0)), N'Mirna', N'Pape', CAST(22 AS Numeric(18, 0)), N'Femenino', CAST(39854726 AS Numeric(18, 0)), N'Ciudadela', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', CAST(N'2021-04-06T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Desocupados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Fecha ultimo trabajo], [Ayuda estatal]) VALUES (CAST(6 AS Numeric(18, 0)), N'Andres', N'Carulo', CAST(45 AS Numeric(18, 0)), N'Masculino', CAST(29863254 AS Numeric(18, 0)), N'Ciudadela', N'Casado', CAST(3 AS Numeric(18, 0)), N'Secundario', CAST(N'2021-01-15T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Desocupados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Fecha ultimo trabajo], [Ayuda estatal]) VALUES (CAST(7 AS Numeric(18, 0)), N'Monica', N'Ferche', CAST(29 AS Numeric(18, 0)), N'Femenino', CAST(31569482 AS Numeric(18, 0)), N'Tapiales', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', CAST(N'2020-07-10T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Desocupados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Fecha ultimo trabajo], [Ayuda estatal]) VALUES (CAST(8 AS Numeric(18, 0)), N'Rebeca', N'Loria', CAST(55 AS Numeric(18, 0)), N'Femenino', CAST(24896352 AS Numeric(18, 0)), N'Ramos Mejia', N'Casado', CAST(3 AS Numeric(18, 0)), N'Universitario', CAST(N'2020-09-12T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Desocupados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Fecha ultimo trabajo], [Ayuda estatal]) VALUES (CAST(9 AS Numeric(18, 0)), N'Samantha', N'Lescano', CAST(40 AS Numeric(18, 0)), N'Femenino', CAST(31695869 AS Numeric(18, 0)), N'Tapiales', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', CAST(N'2019-06-26T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Desocupados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Fecha ultimo trabajo], [Ayuda estatal]) VALUES (CAST(10 AS Numeric(18, 0)), N'Martin', N'Ternerito', CAST(20 AS Numeric(18, 0)), N'Otro', CAST(43695821 AS Numeric(18, 0)), N'Caseros', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', CAST(N'2020-05-15T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Desocupados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Fecha ultimo trabajo], [Ayuda estatal]) VALUES (CAST(11 AS Numeric(18, 0)), N'Horacio', N'Cabak', CAST(48 AS Numeric(18, 0)), N'Masculino', CAST(25986325 AS Numeric(18, 0)), N'Villa Urquiza', N'Casado', CAST(2 AS Numeric(18, 0)), N'Secundario', CAST(N'2021-02-11T00:00:00.000' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[Desocupados] OFF
GO
SET IDENTITY_INSERT [dbo].[Estudiante_Trabajador] ON 
GO
INSERT [dbo].[Estudiante_Trabajador] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(1 AS Numeric(18, 0)), N'Lisardo', N'Dader', CAST(26 AS Numeric(18, 0)), N'Otro', CAST(39896526 AS Numeric(18, 0)), N'Ramos Mejia', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'Unlam', N'Universitario', N'Medicina', 1, 1, CAST(40 AS Numeric(18, 0)))
GO
INSERT [dbo].[Estudiante_Trabajador] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(2 AS Numeric(18, 0)), N'Maximo', N'Serrano', CAST(21 AS Numeric(18, 0)), N'Masculino', CAST(41965365 AS Numeric(18, 0)), N'Ramos Mejia', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'UTN', N'Universitario', N'Ingenieria electronica', 1, 1, CAST(30 AS Numeric(18, 0)))
GO
INSERT [dbo].[Estudiante_Trabajador] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(3 AS Numeric(18, 0)), N'Maria', N'Becerri', CAST(19 AS Numeric(18, 0)), N'Otro', CAST(43658956 AS Numeric(18, 0)), N'Ramos Mejia', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'Unlam', N'Universitario', N'Educacion fisica', 0, 1, CAST(20 AS Numeric(18, 0)))
GO
INSERT [dbo].[Estudiante_Trabajador] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(4 AS Numeric(18, 0)), N'Laura', N'Pipi', CAST(28 AS Numeric(18, 0)), N'Femenino', CAST(38658962 AS Numeric(18, 0)), N'Lomas Del MNirador', N'Soltero', CAST(2 AS Numeric(18, 0)), N'Secundario', N'UBA', N'Universitario', N'Derecho', 0, 0, CAST(40 AS Numeric(18, 0)))
GO
INSERT [dbo].[Estudiante_Trabajador] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(5 AS Numeric(18, 0)), N'Antonia', N'Mimina', CAST(24 AS Numeric(18, 0)), N'Femenino', CAST(40563256 AS Numeric(18, 0)), N'Tapiales', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'Unlam', N'Universitario', N'Relaciones publicas', 1, 1, CAST(30 AS Numeric(18, 0)))
GO
INSERT [dbo].[Estudiante_Trabajador] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(6 AS Numeric(18, 0)), N'Valentin', N'Dader', CAST(23 AS Numeric(18, 0)), N'Masculino', CAST(39625478 AS Numeric(18, 0)), N'Tapiales', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Primario', N'Mariano Moreno', N'Secundario', N'Bachiller', 0, 1, CAST(45 AS Numeric(18, 0)))
GO
INSERT [dbo].[Estudiante_Trabajador] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(7 AS Numeric(18, 0)), N'Pablo', N'Carlis', CAST(33 AS Numeric(18, 0)), N'Masculino', CAST(33652958 AS Numeric(18, 0)), N'Lomas Del Mirador', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'UTN', N'Terciario', N'Programacion', 0, 0, CAST(40 AS Numeric(18, 0)))
GO
INSERT [dbo].[Estudiante_Trabajador] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(8 AS Numeric(18, 0)), N'Melisa', N'Loscago', CAST(31 AS Numeric(18, 0)), N'Femenino', CAST(35968547 AS Numeric(18, 0)), N'Lomas Del Mirador', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'Unlam', N'Terciario', N'Psicomotricidad', 0, 1, CAST(30 AS Numeric(18, 0)))
GO
INSERT [dbo].[Estudiante_Trabajador] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(9 AS Numeric(18, 0)), N'Kevin', N'Jonas', CAST(22 AS Numeric(18, 0)), N'Otro', CAST(41236902 AS Numeric(18, 0)), N'Caseros', N'Soltero', CAST(1 AS Numeric(18, 0)), N'Secundario', N'UTN', N'Terciario', N'Analista de sistemas', 0, 1, CAST(30 AS Numeric(18, 0)))
GO
INSERT [dbo].[Estudiante_Trabajador] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(10 AS Numeric(18, 0)), N'Julian', N'Pupo', CAST(30 AS Numeric(18, 0)), N'Masculino', CAST(37965842 AS Numeric(18, 0)), N'Caseros', N'Casado', CAST(2 AS Numeric(18, 0)), N'Secundario', N'Unlam', N'Universitario', N'Derecho', 1, 1, CAST(40 AS Numeric(18, 0)))
GO
INSERT [dbo].[Estudiante_Trabajador] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(11 AS Numeric(18, 0)), N'Juliana', N'Redefertu', CAST(22 AS Numeric(18, 0)), N'Femenino', CAST(49587456 AS Numeric(18, 0)), N'Burzaco', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'UTN', N'Terciario', N'Programacion', 0, 0, CAST(30 AS Numeric(18, 0)))
GO
INSERT [dbo].[Estudiante_Trabajador] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(12 AS Numeric(18, 0)), N'Trinity', N'Goycochea', CAST(26 AS Numeric(18, 0)), N'Otro', CAST(46854789 AS Numeric(18, 0)), N'Longchamps', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Terciario', N'UBA', N'Universitario', N'Medicina', 1, 1, CAST(35 AS Numeric(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Estudiante_Trabajador] OFF
GO
SET IDENTITY_INSERT [dbo].[Estudiantes] ON 
GO
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera]) VALUES (CAST(1 AS Numeric(18, 0)), N'Tomas', N'Gago', CAST(20 AS Numeric(18, 0)), N'Masculino', CAST(42896325 AS Numeric(18, 0)), N'Ramos Mejia', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'UTN', N'Terciario', N'Programacion')
GO
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera]) VALUES (CAST(2 AS Numeric(18, 0)), N'Laura', N'Ferde', CAST(19 AS Numeric(18, 0)), N'Otro', CAST(43695874 AS Numeric(18, 0)), N'Ciudadela', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'UTN', N'Terciario', N'Analista de sistemas')
GO
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera]) VALUES (CAST(3 AS Numeric(18, 0)), N'Carla', N'Luiato', CAST(22 AS Numeric(18, 0)), N'Femenino', CAST(40896543 AS Numeric(18, 0)), N'Ramos Mejia', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'Unlam', N'Universitario', N'Derecho')
GO
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera]) VALUES (CAST(4 AS Numeric(18, 0)), N'Lorenzo', N'Jadeo', CAST(24 AS Numeric(18, 0)), N'Otro', CAST(39897425 AS Numeric(18, 0)), N'Caseros', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'Uba', N'Universitario', N'Programacion')
GO
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera]) VALUES (CAST(5 AS Numeric(18, 0)), N'Mateo', N'Araujo', CAST(26 AS Numeric(18, 0)), N'Otro', CAST(43692854 AS Numeric(18, 0)), N'Lomas Del Mirador', N'Casado', CAST(1 AS Numeric(18, 0)), N'Secundario', N'UTN', N'Terciario', N'Programacion')
GO
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera]) VALUES (CAST(6 AS Numeric(18, 0)), N'Pablo', N'Perez', CAST(22 AS Numeric(18, 0)), N'Masculino', CAST(43325684 AS Numeric(18, 0)), N'Tapiales', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'Unlam', N'Universitario', N'Educacion fisica')
GO
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera]) VALUES (CAST(7 AS Numeric(18, 0)), N'Melina', N'Tabori', CAST(25 AS Numeric(18, 0)), N'Femenino', CAST(38963251 AS Numeric(18, 0)), N'Tapiales', N'Soltero', CAST(2 AS Numeric(18, 0)), N'Primario', N'Mariano Moreno', N'Secundario', N'Bachiller')
GO
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera]) VALUES (CAST(8 AS Numeric(18, 0)), N'Belen', N'Aybar', CAST(20 AS Numeric(18, 0)), N'Femenino', CAST(44581263 AS Numeric(18, 0)), N'Ramos Mejia', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'UTN', N'Terciario', N'Seguridad e higiene')
GO
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera]) VALUES (CAST(9 AS Numeric(18, 0)), N'Noemi', N'Nureto', CAST(19 AS Numeric(18, 0)), N'Otro', CAST(44652145 AS Numeric(18, 0)), N'Ciudadela', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'Uba', N'Universitario', N'Ingenieria industrial')
GO
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Establecimiento], [Nivel], [Carrera]) VALUES (CAST(10 AS Numeric(18, 0)), N'Pilar', N'Mastronardi', CAST(21 AS Numeric(18, 0)), N'Femenino', CAST(42895632 AS Numeric(18, 0)), N'Caseros', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', N'Unlam', N'Universitario', N'Derecho')
GO
SET IDENTITY_INSERT [dbo].[Estudiantes] OFF
GO
SET IDENTITY_INSERT [dbo].[Jubilados] ON 
GO
INSERT [dbo].[Jubilados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [anio jubilacion], [Sigue trabajando]) VALUES (CAST(1 AS Numeric(18, 0)), N'Josefa', N'Mitre', CAST(66 AS Numeric(18, 0)), N'Femenino', CAST(21563259 AS Numeric(18, 0)), N'Ramos Mejia', N'Casado', CAST(2 AS Numeric(18, 0)), N'Universitario', CAST(2015 AS Numeric(18, 0)), 0)
GO
INSERT [dbo].[Jubilados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [anio jubilacion], [Sigue trabajando]) VALUES (CAST(2 AS Numeric(18, 0)), N'Pepe', N'Mitre', CAST(69 AS Numeric(18, 0)), N'Masculino', CAST(20986325 AS Numeric(18, 0)), N'Ramos Mejia', N'Casado', CAST(3 AS Numeric(18, 0)), N'Secundario', CAST(2016 AS Numeric(18, 0)), 1)
GO
INSERT [dbo].[Jubilados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [anio jubilacion], [Sigue trabajando]) VALUES (CAST(3 AS Numeric(18, 0)), N'Juan', N'Faferto', CAST(72 AS Numeric(18, 0)), N'Masculino', CAST(19863254 AS Numeric(18, 0)), N'Ciudadela', N'Casado', CAST(1 AS Numeric(18, 0)), N'Primario', CAST(2014 AS Numeric(18, 0)), 0)
GO
INSERT [dbo].[Jubilados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [anio jubilacion], [Sigue trabajando]) VALUES (CAST(4 AS Numeric(18, 0)), N'Pedro', N'Gareme', CAST(65 AS Numeric(18, 0)), N'Masculino', CAST(23658965 AS Numeric(18, 0)), N'Tapiales', N'Casado', CAST(2 AS Numeric(18, 0)), N'Secundario', CAST(2021 AS Numeric(18, 0)), 1)
GO
INSERT [dbo].[Jubilados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [anio jubilacion], [Sigue trabajando]) VALUES (CAST(5 AS Numeric(18, 0)), N'Marta', N'Benbeta', CAST(63 AS Numeric(18, 0)), N'Femenino', CAST(23695845 AS Numeric(18, 0)), N'Tapiales', N'Casado', CAST(3 AS Numeric(18, 0)), N'Secundario', CAST(2018 AS Numeric(18, 0)), 0)
GO
INSERT [dbo].[Jubilados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [anio jubilacion], [Sigue trabajando]) VALUES (CAST(6 AS Numeric(18, 0)), N'Mirta', N'Busnelli', CAST(65 AS Numeric(18, 0)), N'Femenino', CAST(22693521 AS Numeric(18, 0)), N'Caseros', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Universitario', CAST(2016 AS Numeric(18, 0)), 0)
GO
INSERT [dbo].[Jubilados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [anio jubilacion], [Sigue trabajando]) VALUES (CAST(7 AS Numeric(18, 0)), N'Luis', N'Nono', CAST(76 AS Numeric(18, 0)), N'Masculino', CAST(18963254 AS Numeric(18, 0)), N'Ramos Mejia', N'Casado', CAST(4 AS Numeric(18, 0)), N'Universitario', CAST(2012 AS Numeric(18, 0)), 0)
GO
INSERT [dbo].[Jubilados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [anio jubilacion], [Sigue trabajando]) VALUES (CAST(8 AS Numeric(18, 0)), N'Gabriel', N'Junar', CAST(68 AS Numeric(18, 0)), N'Masculino', CAST(24589632 AS Numeric(18, 0)), N'Lomas Del Mirador', N'Casado', CAST(2 AS Numeric(18, 0)), N'Secundario', CAST(2018 AS Numeric(18, 0)), 1)
GO
INSERT [dbo].[Jubilados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [anio jubilacion], [Sigue trabajando]) VALUES (CAST(9 AS Numeric(18, 0)), N'Norma', N'Liyaya', CAST(64 AS Numeric(18, 0)), N'Femenino', CAST(23695847 AS Numeric(18, 0)), N'Lomas Del Mirador', N'Casado', CAST(1 AS Numeric(18, 0)), N'Primario', CAST(2017 AS Numeric(18, 0)), 1)
GO
INSERT [dbo].[Jubilados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [anio jubilacion], [Sigue trabajando]) VALUES (CAST(10 AS Numeric(18, 0)), N'Domingo', N'Franco', CAST(67 AS Numeric(18, 0)), N'Masculino', CAST(22569365 AS Numeric(18, 0)), N'Tapiales', N'Casado', CAST(1 AS Numeric(18, 0)), N'Secundario', CAST(2019 AS Numeric(18, 0)), 1)
GO
INSERT [dbo].[Jubilados] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [anio jubilacion], [Sigue trabajando]) VALUES (CAST(11 AS Numeric(18, 0)), N'Yanet', N'Vulvis', CAST(63 AS Numeric(18, 0)), N'Femenino', CAST(19365258 AS Numeric(18, 0)), N'Tapiales', N'Casado', CAST(2 AS Numeric(18, 0)), N'Secundario', CAST(2018 AS Numeric(18, 0)), 0)
GO
SET IDENTITY_INSERT [dbo].[Jubilados] OFF
GO
SET IDENTITY_INSERT [dbo].[Trabajadores] ON 
GO
INSERT [dbo].[Trabajadores] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(1 AS Numeric(18, 0)), N'Pepe', N'Perez', CAST(45 AS Numeric(18, 0)), N'Masculino', CAST(30560489 AS Numeric(18, 0)), N'Lomas Del Mirador', N'Casado', CAST(2 AS Numeric(18, 0)), N'Secundario', 1, 1, CAST(45 AS Numeric(18, 0)))
GO
INSERT [dbo].[Trabajadores] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(2 AS Numeric(18, 0)), N'Sara', N'Miller', CAST(39 AS Numeric(18, 0)), N'Femenino', CAST(32987456 AS Numeric(18, 0)), N'Ramos Mejia', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', 1, 1, CAST(50 AS Numeric(18, 0)))
GO
INSERT [dbo].[Trabajadores] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(3 AS Numeric(18, 0)), N'Flavia', N'Dente', CAST(49 AS Numeric(18, 0)), N'Femenino', CAST(28963258 AS Numeric(18, 0)), N'Caseros', N'Casado', CAST(3 AS Numeric(18, 0)), N'Primario', 0, 1, CAST(55 AS Numeric(18, 0)))
GO
INSERT [dbo].[Trabajadores] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(4 AS Numeric(18, 0)), N'Dario', N'Ferchon', CAST(27 AS Numeric(18, 0)), N'Otro', CAST(38124578 AS Numeric(18, 0)), N'Lomas Del Mirador', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Secundario', 0, 0, CAST(45 AS Numeric(18, 0)))
GO
INSERT [dbo].[Trabajadores] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(5 AS Numeric(18, 0)), N'Lucas', N'Babe', CAST(30 AS Numeric(18, 0)), N'Masculino', CAST(35987456 AS Numeric(18, 0)), N'Tapiales', N'Soltero', CAST(1 AS Numeric(18, 0)), N'Secundario', 1, 0, CAST(60 AS Numeric(18, 0)))
GO
INSERT [dbo].[Trabajadores] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(6 AS Numeric(18, 0)), N'Daniel', N'Rimpi', CAST(55 AS Numeric(18, 0)), N'Masculino', CAST(25897463 AS Numeric(18, 0)), N'Ciudadela', N'Casado', CAST(4 AS Numeric(18, 0)), N'Primario', 0, 1, CAST(45 AS Numeric(18, 0)))
GO
INSERT [dbo].[Trabajadores] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(7 AS Numeric(18, 0)), N'Leila', N'Culi', CAST(25 AS Numeric(18, 0)), N'Otro', CAST(39854126 AS Numeric(18, 0)), N'Ciudadela', N'Soltero', CAST(1 AS Numeric(18, 0)), N'Secundario', 0, 0, CAST(40 AS Numeric(18, 0)))
GO
INSERT [dbo].[Trabajadores] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(8 AS Numeric(18, 0)), N'Berta', N'Chancle', CAST(21 AS Numeric(18, 0)), N'Femenino', CAST(40986325 AS Numeric(18, 0)), N'Lomas Del Mirador', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Primario', 0, 1, CAST(55 AS Numeric(18, 0)))
GO
INSERT [dbo].[Trabajadores] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(9 AS Numeric(18, 0)), N'Luis', N'Neron', CAST(60 AS Numeric(18, 0)), N'Masculino', CAST(22893175 AS Numeric(18, 0)), N'Ramos Mejia', N'Casado', CAST(2 AS Numeric(18, 0)), N'Universitario', 1, 1, CAST(40 AS Numeric(18, 0)))
GO
INSERT [dbo].[Trabajadores] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(10 AS Numeric(18, 0)), N'Jose', N'Sertal', CAST(63 AS Numeric(18, 0)), N'Masculino', CAST(20986158 AS Numeric(18, 0)), N'Caseros', N'Soltero', CAST(0 AS Numeric(18, 0)), N'Primario', 0, 0, CAST(55 AS Numeric(18, 0)))
GO
INSERT [dbo].[Trabajadores] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(11 AS Numeric(18, 0)), N'Oscar', N'Sabela', CAST(60 AS Numeric(18, 0)), N'Masculino', CAST(25896853 AS Numeric(18, 0)), N'Savedra', N'Casado', CAST(4 AS Numeric(18, 0)), N'Secundario', 1, 0, CAST(50 AS Numeric(18, 0)))
GO
INSERT [dbo].[Trabajadores] ([Id], [Nombre], [Apellido], [Edad], [Sexo], [Dni], [Localidad], [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) VALUES (CAST(12 AS Numeric(18, 0)), N'Yusepina', N'Contractil', CAST(52 AS Numeric(18, 0)), N'Femenino', CAST(24985463 AS Numeric(18, 0)), N'Flores', N'Casado', CAST(3 AS Numeric(18, 0)), N'Universitario', 1, 1, CAST(45 AS Numeric(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Trabajadores] OFF
GO
USE [master]
GO
ALTER DATABASE [Censo] SET  READ_WRITE 
GO
