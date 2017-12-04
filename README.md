# sisent-crud

Projek ini adalah projek untuk mata kuliah Sistem Enterprise

## Getting Started

### Prerequisites
* Visual Studio min. 2013
* SQL Server Management Studio (disarankan 2014)

### Initial

* Buka sebuah connection di dalam SQL Server Management Studio. Dalam hal ini, konfigurasi untuk connection dapat diubah dalam file clsKoneksi.vb, dan mengarah pada
```
    Public Function OpenConn() As Boolean
        Conn = New SqlConnection("Data Source=ALPHA\ITD;" _
                               & "Initial Catalog=DB_AKADEMIK;" _
                               & "Integrated Security=True")
        Conn.Open()
        If Conn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function
```
* Ubah value dari Data Source menjadi connection name pada mesin anda.
* Bentuk sebuah data base dengan nama DB_AKADEMIK
* Gunakan SQL berikut untuk membuat sebuah tabel Tbl_Mahasiswa

```
USE [DB_AKADEMIK]
GO

/****** Object:  Table [dbo].[Tbl_Mahasiswa]    Script Date: 12/4/2017 4:27:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Mahasiswa](
	[NIM] [char](5) NOT NULL,
	[NAMA] [varchar](50) NULL,
	[ALAMAT] [varchar](50) NULL,
	[JURUSAN] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_Mahasiswa] PRIMARY KEY CLUSTERED 
(
	[NIM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

```
