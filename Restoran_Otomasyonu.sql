USE [Restaurant]
GO
/****** Object:  Table [dbo].[adisyon]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adisyon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PERSONELID] [int] NULL,
	[MASAID] [int] NULL,
	[SERVISTURNO] [int] NULL,
	[TARIH] [datetime] NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_adisyon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hesapOdemeleri]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hesapOdemeleri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ADISYONID] [int] NULL,
	[ODEMETURID] [int] NULL,
	[MUSTERIID] [int] NULL,
	[ARATOPLAM] [money] NULL,
	[KDVTUTARI] [money] NULL,
	[INDIRIM] [money] NULL,
	[TOPLAMTUTAR] [money] NULL,
	[TARIH] [datetime] NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_hesapOdemeleri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kategoriler]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kategoriler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KATEGORIADI] [nvarchar](100) NULL,
	[ACIKLAMA] [text] NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_kategoriler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[masalar]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[masalar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KAPASITE] [int] NULL,
	[SERVISTURU] [int] NULL,
	[DURUM] [bit] NULL CONSTRAINT [DF_Table_1_Durum]  DEFAULT ((0)),
 CONSTRAINT [PK_Masalar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[musteriler]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteriler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AD] [nvarchar](50) NULL,
	[SOYAD] [nvarchar](50) NULL,
	[ADRES] [text] NULL,
	[TELEFON] [nvarchar](50) NULL,
	[ILKSIPARIS] [date] NULL,
	[EMAIL] [nvarchar](50) NULL,
	[SIPARISSAYISI] [int] NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_musteriler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[odemeTurleri]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[odemeTurleri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ODEMETURU] [nvarchar](50) NULL,
	[ACIKLAMA] [text] NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_odemeTurleri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[paketSiparis]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paketSiparis](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MUSTERIID] [int] NULL,
	[ADISYONID] [int] NULL,
	[ODEMETURID] [int] NULL,
	[ACIKLAMA] [text] NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_paketSiparis] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personelGorevleri]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personelGorevleri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GOREV] [nvarchar](100) NULL,
	[ACIKLAMA] [text] NULL,
	[DURUM] [bit] NULL CONSTRAINT [DF_personelGorevleri_DURUM]  DEFAULT ((0)),
 CONSTRAINT [PK_personelGorevleri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personelHareketleri]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personelHareketleri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PERSONELID] [int] NULL,
	[ISLEM] [nvarchar](50) NULL,
	[TARIH] [datetime] NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_personelHareketleri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personeller]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personeller](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GOREVID] [int] NULL,
	[AD] [nvarchar](50) NULL,
	[SOYAD] [nvarchar](50) NULL,
	[PAROLA] [nvarchar](50) NULL,
	[KULLANICIADI] [nvarchar](50) NULL,
	[DURUM] [bit] NULL CONSTRAINT [DF_personeller_DURUM]  DEFAULT ((0)),
 CONSTRAINT [PK_personeller] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[rezervasyonlar]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rezervasyonlar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MUSTERIID] [int] NULL,
	[MASAID] [int] NULL,
	[ADISYONID] [int] NULL,
	[TARIH] [datetime] NULL,
	[KISISAYISI] [int] NULL,
	[ACIKLAMA] [text] NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_rezervasyonlar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[satislar]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satislar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ADISYONID] [int] NULL,
	[URUNID] [int] NULL,
	[MASAID] [int] NULL,
	[ADET] [int] NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_satislar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[servisturu]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servisturu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SERVISADI] [nvarchar](50) NULL,
	[ACIKLAMA] [text] NULL,
 CONSTRAINT [PK_servisturu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[urunler]    Script Date: 12.12.2021 00:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urunler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KATEGORIID] [int] NULL,
	[URUNAD] [nvarchar](100) NULL,
	[ACIKLAMA] [text] NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_urunler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[adisyon] ADD  CONSTRAINT [DF_adisyon_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[hesapOdemeleri] ADD  CONSTRAINT [DF_hesapOdemeleri_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[kategoriler] ADD  CONSTRAINT [DF_kategoriler_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[musteriler] ADD  CONSTRAINT [DF_musteriler_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[odemeTurleri] ADD  CONSTRAINT [DF_odemeTurleri_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[paketSiparis] ADD  CONSTRAINT [DF_paketSiparis_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[personelHareketleri] ADD  CONSTRAINT [DF_personelHareketleri_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[rezervasyonlar] ADD  CONSTRAINT [DF_rezervasyonlar_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[satislar] ADD  CONSTRAINT [DF_satislar_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[urunler] ADD  CONSTRAINT [DF_urunler_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[adisyon]  WITH CHECK ADD  CONSTRAINT [FK_adisyon_personeller] FOREIGN KEY([PERSONELID])
REFERENCES [dbo].[personeller] ([ID])
GO
ALTER TABLE [dbo].[adisyon] CHECK CONSTRAINT [FK_adisyon_personeller]
GO
ALTER TABLE [dbo].[adisyon]  WITH CHECK ADD  CONSTRAINT [FK_adisyon_servisturu] FOREIGN KEY([SERVISTURNO])
REFERENCES [dbo].[servisturu] ([ID])
GO
ALTER TABLE [dbo].[adisyon] CHECK CONSTRAINT [FK_adisyon_servisturu]
GO
ALTER TABLE [dbo].[hesapOdemeleri]  WITH CHECK ADD  CONSTRAINT [FK_hesapOdemeleri_adisyon] FOREIGN KEY([ADISYONID])
REFERENCES [dbo].[adisyon] ([ID])
GO
ALTER TABLE [dbo].[hesapOdemeleri] CHECK CONSTRAINT [FK_hesapOdemeleri_adisyon]
GO
ALTER TABLE [dbo].[hesapOdemeleri]  WITH CHECK ADD  CONSTRAINT [FK_hesapOdemeleri_musteriler] FOREIGN KEY([MUSTERIID])
REFERENCES [dbo].[musteriler] ([ID])
GO
ALTER TABLE [dbo].[hesapOdemeleri] CHECK CONSTRAINT [FK_hesapOdemeleri_musteriler]
GO
ALTER TABLE [dbo].[hesapOdemeleri]  WITH CHECK ADD  CONSTRAINT [FK_hesapOdemeleri_odemeTurleri] FOREIGN KEY([ODEMETURID])
REFERENCES [dbo].[odemeTurleri] ([ID])
GO
ALTER TABLE [dbo].[hesapOdemeleri] CHECK CONSTRAINT [FK_hesapOdemeleri_odemeTurleri]
GO
ALTER TABLE [dbo].[kategoriler]  WITH CHECK ADD  CONSTRAINT [FK_kategoriler_urunler] FOREIGN KEY([ID])
REFERENCES [dbo].[urunler] ([ID])
GO
ALTER TABLE [dbo].[kategoriler] CHECK CONSTRAINT [FK_kategoriler_urunler]
GO
ALTER TABLE [dbo].[paketSiparis]  WITH CHECK ADD  CONSTRAINT [FK_paketSiparis_musteriler] FOREIGN KEY([MUSTERIID])
REFERENCES [dbo].[musteriler] ([ID])
GO
ALTER TABLE [dbo].[paketSiparis] CHECK CONSTRAINT [FK_paketSiparis_musteriler]
GO
ALTER TABLE [dbo].[paketSiparis]  WITH CHECK ADD  CONSTRAINT [FK_paketSiparis_odemeTurleri] FOREIGN KEY([ODEMETURID])
REFERENCES [dbo].[odemeTurleri] ([ID])
GO
ALTER TABLE [dbo].[paketSiparis] CHECK CONSTRAINT [FK_paketSiparis_odemeTurleri]
GO
ALTER TABLE [dbo].[personeller]  WITH CHECK ADD  CONSTRAINT [FK_personeller_personelGorevleri] FOREIGN KEY([GOREVID])
REFERENCES [dbo].[personelGorevleri] ([ID])
GO
ALTER TABLE [dbo].[personeller] CHECK CONSTRAINT [FK_personeller_personelGorevleri]
GO
ALTER TABLE [dbo].[rezervasyonlar]  WITH CHECK ADD  CONSTRAINT [FK_rezervasyonlar_adisyon] FOREIGN KEY([ADISYONID])
REFERENCES [dbo].[adisyon] ([ID])
GO
ALTER TABLE [dbo].[rezervasyonlar] CHECK CONSTRAINT [FK_rezervasyonlar_adisyon]
GO
ALTER TABLE [dbo].[rezervasyonlar]  WITH CHECK ADD  CONSTRAINT [FK_rezervasyonlar_masalar] FOREIGN KEY([MASAID])
REFERENCES [dbo].[masalar] ([ID])
GO
ALTER TABLE [dbo].[rezervasyonlar] CHECK CONSTRAINT [FK_rezervasyonlar_masalar]
GO
ALTER TABLE [dbo].[satislar]  WITH CHECK ADD  CONSTRAINT [FK_satislar_rezervasyonlar] FOREIGN KEY([ADISYONID])
REFERENCES [dbo].[rezervasyonlar] ([ID])
GO
ALTER TABLE [dbo].[satislar] CHECK CONSTRAINT [FK_satislar_rezervasyonlar]
GO
ALTER TABLE [dbo].[satislar]  WITH CHECK ADD  CONSTRAINT [FK_satislar_urunler] FOREIGN KEY([URUNID])
REFERENCES [dbo].[urunler] ([ID])
GO
ALTER TABLE [dbo].[satislar] CHECK CONSTRAINT [FK_satislar_urunler]
GO
