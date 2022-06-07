-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 07 Jun 2022 pada 15.16
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rekam_medis`
--

DELIMITER $$
--
-- Prosedur
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `DokterHAPUS` (`kodedok` CHAR(10))   BEGIN
 delete from tdokter where kode_dok=kodedok;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DokterTAMBAH` (`kode_dok` CHAR(10), `nama_dok` VARCHAR(25), `kelamin` CHAR(15), `spesialis` VARCHAR(30), `alamat` VARCHAR(50), `kota` CHAR(15), `telpon` VARCHAR(30), `email` VARCHAR(50))   BEGIN
 insert into tdokter values(kode_dok,nama_dok,kelamin,spesialis,alamat,kota,telpon,email);
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DokterUBAH` (`kodedok` CHAR(10), `nama_dok` VARCHAR(25), `kelamin` CHAR(15), `spesialis` VARCHAR(30), `alamat` VARCHAR(50), `kota` CHAR(15), `telpon` VARCHAR(30), `email` VARCHAR(50))   BEGIN
 update tdokter set nama_dok=nama_dok,kelamin=kelamin,spesialis=spesialis,alamat=alamat,kota=kota,telpon=telpon,email=email where kode_dok=kodedok;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObatHAPUS` (`kodeobat` CHAR(10))   BEGIN
 delete from tobat where kode_obat=kodeobat;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObatTAMBAH` (`kode_obat` CHAR(10), `nama_obat` VARCHAR(25), `jenis` VARCHAR(40), `kemasan` CHAR(30), `harga_obat` DECIMAL(9), `jumlah_obat` DECIMAL(7))   BEGIN
 insert into tobat values(kode_obat,nama_obat,jenis,kemasan,harga_obat,jumlah_obat);
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObatUBAH` (IN `kodeobat` CHAR(10), IN `nama_obat` VARCHAR(25), IN `jenis` VARCHAR(40), IN `kemasan` CHAR(30), IN `harga_obat` DECIMAL(9), IN `jumlah_obat` DECIMAL(7))   BEGIN
 update tobat set nama_obat=nama_obat,jenis=jenis,kemasan=kemasan,harga_obat=harga_obat,jumlah_obat=jumlah_obat
 WHERE kode_obat = kodeobat;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PasienHAPUS` (IN `kodepas` CHAR(10))   BEGIN
 delete from tpasien where kode_pas=kodepas;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PasienTAMBAH` (IN `kode_pas` CHAR(10), IN `nama_pas` VARCHAR(25), IN `kelamin` CHAR(10), IN `usia` INT, IN `pekerjaan` CHAR(30), IN `ktp` VARCHAR(15), IN `alamat` VARCHAR(50), IN `kota` VARCHAR(15), IN `telpon` VARCHAR(30), IN `email` VARCHAR(30))   BEGIN
 insert into tpasien values(kode_pas,nama_pas,kelamin,usia,pekerjaan,ktp,alamat,kota,telpon,email);
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PasienUBAH` (IN `kodepas` CHAR(10), IN `nama_pas` VARCHAR(25), IN `kelamin` CHAR(10), IN `usia` INT, IN `pekerjaan` CHAR(30), IN `ktp` VARCHAR(15), IN `alamat` VARCHAR(50), IN `kota` VARCHAR(15), IN `telpon` VARCHAR(30), IN `email` VARCHAR(30))   BEGIN
 update tpasien set nama_pas=nama_pas,kelamin=kelamin,usia=usia,pekerjaan=pekerjaan,ktp=ktp,alamat=alamat,kota=kota,telpon=telpon,email=email where kode_pas=kodepas;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PegawaiHAPUS` (IN `vnip` CHAR(10))   BEGIN
 delete from tpegawai where nip=vnip;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PegawaiTAMBAH` (IN `nip` CHAR(10), IN `nama` VARCHAR(35), IN `kelamin` VARCHAR(15), IN `agama` VARCHAR(15), IN `usia` INT, IN `ktp` VARCHAR(50), IN `jabatan` VARCHAR(20), IN `alamat` VARCHAR(50), IN `kota` VARCHAR(25), IN `telepon` VARCHAR(30), IN `email` VARCHAR(30))   BEGIN
    insert into tpegawai values(nip,nama,kelamin,agama,usia,ktp,jabatan,alamat,kota,telepon,email);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PegawaiUBAH` (IN `vnip` CHAR(10), IN `nama` VARCHAR(35), IN `kelamin` VARCHAR(15), IN `agama` VARCHAR(15), IN `usia` INT, IN `ktp` VARCHAR(50), IN `jabatan` VARCHAR(20), IN `alamat` VARCHAR(50), IN `kota` VARCHAR(25), IN `telepon` VARCHAR(30), IN `email` VARCHAR(30))   BEGIN
  update tpegawai set nama=nama,kelamin=kelamin,agama=agama,usia=usia,ktp=ktp,jabatan=jabatan,alamat=alamat,kota=kota,telepon=telepon,email=email
  where nip=vnip;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcStockObat` (`kd_obat` CHAR(10), `jmlh_obat` NUMERIC(7))   BEGIN
 update tobat set jumlah_obat=jumlah_obat-jmlh_obat where kode_obat=kd_obat;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tdokter`
--

CREATE TABLE `tdokter` (
  `kode_dok` char(10) NOT NULL,
  `nama_dok` varchar(25) DEFAULT NULL,
  `kelamin` char(15) DEFAULT NULL,
  `spesialis` varchar(30) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `kota` varchar(15) DEFAULT NULL,
  `telpon` varchar(30) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tdokter`
--

INSERT INTO `tdokter` (`kode_dok`, `nama_dok`, `kelamin`, `spesialis`, `alamat`, `kota`, `telpon`, `email`) VALUES
('D-0001', 'Dwi Nugroho', 'Pria', 'Anak', 'LPH, Lembah Melati No.125', 'Bandung', '022-1234567', 'nugroho@gmail.com'),
('D-002', 'Adi Wijaya', 'Pria', 'G i g i', 'Jln Perkici No. 21', 'Tangerang Selat', '021-6754747', 'adiwijaya@gmail.com'),
('D-003', 'Bambang Soesatyo', 'Pria', 'T.H.T.', 'Jln. Menteng Boulevard No. 3', 'Tangerang Selat', '021-8983737', 'bambang@gmail.com');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tlogin`
--

CREATE TABLE `tlogin` (
  `nip` char(10) NOT NULL,
  `pass` char(10) DEFAULT NULL,
  `level_user` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tlogin`
--

INSERT INTO `tlogin` (`nip`, `pass`, `level_user`) VALUES
('P0001', 'admin', '1'),
('P0002', 'P0002', '2'),
('P0003', 'P0003', '2'),
('P0004', 'tampan', '1');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tobat`
--

CREATE TABLE `tobat` (
  `kode_obat` char(10) NOT NULL,
  `nama_obat` varchar(25) DEFAULT NULL,
  `jenis` varchar(40) DEFAULT NULL,
  `kemasan` char(30) CHARACTER SET utf8 DEFAULT NULL,
  `harga_obat` decimal(9,0) DEFAULT NULL,
  `jumlah_obat` decimal(7,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tobat`
--

INSERT INTO `tobat` (`kode_obat`, `nama_obat`, `jenis`, `kemasan`, `harga_obat`, `jumlah_obat`) VALUES
('O-0001', 'Bodrexin', 'Generic', 'Botol', '25000', '2'),
('O-0002', 'Bisolvon', 'Non Generic', 'Botol', '23000', '2'),
('O-0003', 'Neo Bodrex', 'Non Generic', 'Tablet', '50000', '3');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tpasien`
--

CREATE TABLE `tpasien` (
  `kode_pas` char(10) NOT NULL,
  `nama_pas` varchar(25) DEFAULT NULL,
  `kelamin` char(10) DEFAULT NULL,
  `usia` int(11) DEFAULT NULL,
  `pekerjaan` char(30) DEFAULT NULL,
  `ktp` varchar(15) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `kota` varchar(15) DEFAULT NULL,
  `telpon` varchar(30) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tpasien`
--

INSERT INTO `tpasien` (`kode_pas`, `nama_pas`, `kelamin`, `usia`, `pekerjaan`, `ktp`, `alamat`, `kota`, `telpon`, `email`) VALUES
('P-0001', 'Dewi Kurniawan', 'Wanita', 30, 'Pegawai Negeri Sipil', '2013.001', 'LPH, Lembah Anggrek No.100', 'Cimahi Utara', '022-12345678', 'lestari@yahoo.com'),
('P-0004', 'Bima Darmawan', 'Pria', 32, 'Pegawai Negeri Swasta', '2013.004', 'LPH, Lembah Mawar No.150', 'Cimahi Utara', '022-1234567', 'bimadarwaman@gmail.com'),
('P-0005', 'Dafadil Fitra', 'P r i a', 22, 'Pegawai Swasta', '317467383737', 'Jl. Kucica No. 23', 'Jakarta Selatan', '021-9883939', 'dafadil@gmail.com');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tpegawai`
--

CREATE TABLE `tpegawai` (
  `nip` char(10) NOT NULL,
  `nama` varchar(35) DEFAULT NULL,
  `kelamin` varchar(15) DEFAULT NULL,
  `agama` varchar(15) DEFAULT NULL,
  `usia` int(11) DEFAULT NULL,
  `ktp` varchar(55) DEFAULT NULL,
  `jabatan` varchar(20) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `kota` varchar(25) DEFAULT NULL,
  `telepon` varchar(30) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tpegawai`
--

INSERT INTO `tpegawai` (`nip`, `nama`, `kelamin`, `agama`, `usia`, `ktp`, `jabatan`, `alamat`, `kota`, `telepon`, `email`) VALUES
('P0001', 'Nadia Azzahra', 'Wanita', 'Islam', 21, '3174101309000003', 'Owner', 'Jln. Cikini Raya No. 41', 'Jakarta Pusat', '021-74862447', 'andikaaryasatya@gdrive-id.com'),
('P0002', 'Jennifer Listianto', 'Wanita', 'Katholic', 22, '23849938292039', 'General Manager Pela', 'Gang Pandega Marta No. 24', 'Sleman', '0274-282829283', 'umirohmah@gmail.com'),
('P0003', 'Michelle Andrianto Gunawan', 'Wanita', 'Protestan', 21, '23232332412', 'Supervisor Medis', 'LPH, Gang Pandega Padma No. 31', 'Sleman', '0274-56646446', 'ingedpr@gmail.com'),
('P0004', 'Fauzan Fachreza', 'Pria', 'Islam', 23, '37263383874747', 'Vice President', 'Jln. KH. Syafii Hazami No. 21 Kebayoran Village', 'Tangerang selatan', '021-7486787', 'fauzanfachreza@gmail.com'),
('P0005', 'Jessyln Anantara Wijaya', 'Wanita', 'Katholic', 25, '316527283837', 'Perawat', 'Jl. Amarine Blok A2 No. 10', 'Kabupaten Tangerang', '021-3450989', 'jessylnwijaya@gmail.com');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tperiksa`
--

CREATE TABLE `tperiksa` (
  `nomor_rm` char(10) NOT NULL,
  `tgl_perisa` datetime DEFAULT NULL,
  `kode_dok` char(10) NOT NULL,
  `kode_pas` char(10) NOT NULL,
  `diagnosa` varchar(99) DEFAULT NULL,
  `biaya` decimal(9,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tperiksa`
--

INSERT INTO `tperiksa` (`nomor_rm`, `tgl_perisa`, `kode_dok`, `kode_pas`, `diagnosa`, `biaya`) VALUES
('RM-0000001', '2022-06-03 00:00:00', 'D-002', 'P-0005', 'Kanker Kulit', '150000'),
('RM-0000002', '2022-06-03 00:00:00', 'D-002', 'P-0001', 'covid 19', '150000'),
('RM-0000003', '2022-06-03 00:00:00', 'D-0001', 'P-0004', 'Influenza', '0'),
('RM-0000004', '2022-06-03 00:00:00', 'D-003', 'P-0001', 'Insomnia', '0'),
('RM-0000005', '2022-06-03 00:00:00', 'D-002', 'P-0005', 'Mambu Sikil', '150000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tperiksa_detail`
--

CREATE TABLE `tperiksa_detail` (
  `nomor_rm` char(10) NOT NULL,
  `kode_obat` char(10) NOT NULL,
  `biaya_obat` decimal(9,0) DEFAULT NULL,
  `total_biaya` decimal(9,0) DEFAULT NULL,
  `jumlah_total` decimal(9,0) DEFAULT NULL,
  `pajak` decimal(9,0) DEFAULT NULL,
  `total_bayar` decimal(9,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tperiksa_detail`
--

INSERT INTO `tperiksa_detail` (`nomor_rm`, `kode_obat`, `biaya_obat`, `total_biaya`, `jumlah_total`, `pajak`, `total_bayar`) VALUES
('RM-0000002', 'O-0003', '100000', '250000', '250000', '25000', '275000'),
('RM-0000003', 'O-0003', '250000', '250000', '500000', '50000', '550000'),
('RM-0000004', 'O-0003', '250000', '250000', '750000', '75000', '825000'),
('RM-0000005', 'O-0003', '200000', '350000', '350000', '35000', '385000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tperusahaan`
--

CREATE TABLE `tperusahaan` (
  `nama` varchar(50) DEFAULT NULL,
  `alamat` varchar(100) DEFAULT NULL,
  `kota` char(15) DEFAULT NULL,
  `telepon` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tdokter`
--
ALTER TABLE `tdokter`
  ADD PRIMARY KEY (`kode_dok`);

--
-- Indeks untuk tabel `tlogin`
--
ALTER TABLE `tlogin`
  ADD PRIMARY KEY (`nip`);

--
-- Indeks untuk tabel `tobat`
--
ALTER TABLE `tobat`
  ADD PRIMARY KEY (`kode_obat`);

--
-- Indeks untuk tabel `tpasien`
--
ALTER TABLE `tpasien`
  ADD PRIMARY KEY (`kode_pas`);

--
-- Indeks untuk tabel `tpegawai`
--
ALTER TABLE `tpegawai`
  ADD PRIMARY KEY (`nip`);

--
-- Indeks untuk tabel `tperiksa`
--
ALTER TABLE `tperiksa`
  ADD PRIMARY KEY (`nomor_rm`,`kode_dok`,`kode_pas`),
  ADD KEY `FK_dokter` (`kode_dok`),
  ADD KEY `FK_pasien` (`kode_pas`);

--
-- Indeks untuk tabel `tperiksa_detail`
--
ALTER TABLE `tperiksa_detail`
  ADD PRIMARY KEY (`nomor_rm`,`kode_obat`),
  ADD KEY `FK_tobat` (`kode_obat`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tperiksa`
--
ALTER TABLE `tperiksa`
  ADD CONSTRAINT `FK_dokter` FOREIGN KEY (`kode_dok`) REFERENCES `tdokter` (`kode_dok`),
  ADD CONSTRAINT `FK_pasien` FOREIGN KEY (`kode_pas`) REFERENCES `tpasien` (`kode_pas`);

--
-- Ketidakleluasaan untuk tabel `tperiksa_detail`
--
ALTER TABLE `tperiksa_detail`
  ADD CONSTRAINT `FK_tobat` FOREIGN KEY (`kode_obat`) REFERENCES `tobat` (`kode_obat`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
