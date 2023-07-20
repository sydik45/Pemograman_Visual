-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 20, 2023 at 12:01 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lapangan_futsal`
--

-- --------------------------------------------------------

--
-- Table structure for table `futsal`
--

CREATE TABLE `futsal` (
  `id` int(11) NOT NULL,
  `kdf` int(11) NOT NULL,
  `nama` varchar(40) NOT NULL,
  `jk` enum('L','P') NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `tanggal` date NOT NULL,
  `pukul` varchar(30) NOT NULL,
  `jam_main` int(11) NOT NULL,
  `jenis_lapangan` varchar(50) NOT NULL,
  `harga` int(20) NOT NULL,
  `total_harga` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `futsal`
--

INSERT INTO `futsal` (`id`, `kdf`, `nama`, `jk`, `alamat`, `tanggal`, `pukul`, `jam_main`, `jenis_lapangan`, `harga`, `total_harga`) VALUES
(1, 101, 'Sydik', 'L', 'Ciperna', '2023-07-20', '5 sore', 1, 'Semen', 80000, 80000),
(3, 103, 'apa', 'L', 'Cirebon', '2000-11-23', '3 sore', 1, 'Semen', 80000, 80000),
(5, 102, 'BilalA', 'P', 'Cirebon', '2023-11-02', '6 Malam', 4, 'Rumput Sintesis', 120000, 480000);

-- --------------------------------------------------------

--
-- Table structure for table `lapangan`
--

CREATE TABLE `lapangan` (
  `id` int(11) NOT NULL,
  `kode_lapangan` int(11) NOT NULL,
  `jenis_lapangan` varchar(50) NOT NULL,
  `harga` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `lapangan`
--

INSERT INTO `lapangan` (`id`, `kode_lapangan`, `jenis_lapangan`, `harga`) VALUES
(1, 1001, 'Vinyl', 200000),
(2, 1003, 'Parquette', 150000),
(3, 1004, 'Rumput Sintesis', 120000),
(4, 1005, 'Semen', 80000);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `passwd` varchar(50) NOT NULL,
  `rolename` enum('admin','pemilik') NOT NULL DEFAULT 'admin'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `passwd`, `rolename`) VALUES
(1, 'Sydik', '202cb962ac59075b964b07152d234b70', 'admin'),
(2, 'Crankyzy.', '202cb962ac59075b964b07152d234b70', 'pemilik');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `futsal`
--
ALTER TABLE `futsal`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `kdf` (`kdf`);

--
-- Indexes for table `lapangan`
--
ALTER TABLE `lapangan`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `kode_lapangan` (`kode_lapangan`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `idx` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `futsal`
--
ALTER TABLE `futsal`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `lapangan`
--
ALTER TABLE `lapangan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
