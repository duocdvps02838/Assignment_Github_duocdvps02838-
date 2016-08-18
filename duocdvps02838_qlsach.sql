-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 14, 2016 at 10:41 AM
-- Server version: 10.1.10-MariaDB
-- PHP Version: 5.6.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `duocdvps02838_qlsach`
--

-- --------------------------------------------------------

--
-- Table structure for table `hoadon`
--

CREATE TABLE `hoadon` (
  `MAHD` varchar(10) NOT NULL,
  `MAKH` varchar(10) NOT NULL,
  `NGAYLAP` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hoadon`
--

INSERT INTO `hoadon` (`MAHD`, `MAKH`, `NGAYLAP`) VALUES
('HD1', 'KH1', '14/8/2016');

-- --------------------------------------------------------

--
-- Table structure for table `khachhang`
--

CREATE TABLE `khachhang` (
  `MAKH` varchar(10) NOT NULL,
  `TENKH` varchar(20) NOT NULL,
  `DIACHI` varchar(20) NOT NULL,
  `DIENTHOAI` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `khachhang`
--

INSERT INTO `khachhang` (`MAKH`, `TENKH`, `DIACHI`, `DIENTHOAI`) VALUES
('KH1', 'DUOC', 'THU DUC', '7268919');

-- --------------------------------------------------------

--
-- Table structure for table `sach`
--

CREATE TABLE `sach` (
  `MASACH` varchar(10) NOT NULL,
  `TENSACH` varchar(20) NOT NULL,
  `TACGIA` varchar(20) NOT NULL,
  `GIABAN` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sach`
--

INSERT INTO `sach` (`MASACH`, `TENSACH`, `TACGIA`, `GIABAN`) VALUES
('1', 'DAC NHAN TAM', 'XEKO', '25000'),
('2', 'JINDO', 'KAKI', '30000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `hoadon`
--
ALTER TABLE `hoadon`
  ADD PRIMARY KEY (`MAHD`),
  ADD KEY `MAKH` (`MAKH`);

--
-- Indexes for table `khachhang`
--
ALTER TABLE `khachhang`
  ADD PRIMARY KEY (`MAKH`);

--
-- Indexes for table `sach`
--
ALTER TABLE `sach`
  ADD PRIMARY KEY (`MASACH`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `hoadon`
--
ALTER TABLE `hoadon`
  ADD CONSTRAINT `hoadon_ibfk_1` FOREIGN KEY (`MAKH`) REFERENCES `khachhang` (`MAKH`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
