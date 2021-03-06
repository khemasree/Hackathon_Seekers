USE [master]
GO
/****** Object:  Table [dbo].[Deal]    Script Date: 15-04-2018 21:11:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Deal](
	[DId] [int] IDENTITY(1,1) NOT NULL,
	[DSource] [varchar](50) NOT NULL,
	[DProduct] [varchar](max) NOT NULL,
	[DLink] [varchar](max) NOT NULL,
	[DOrgPrice] [decimal](19, 4) NOT NULL,
	[DOffPrice] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_Deal] PRIMARY KEY CLUSTERED 
(
	[DId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
