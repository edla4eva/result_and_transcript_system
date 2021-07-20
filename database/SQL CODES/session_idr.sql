-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 19, 2021 at 06:37 PM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 8.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `result_and_trancript_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `session_idr`
--

CREATE TABLE `session_idr` (
  `session_id` int(11) NOT NULL,
  `session_year` text NOT NULL,
  `comment` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `session_idr`
--

INSERT INTO `session_idr` (`session_id`, `session_year`, `comment`) VALUES
(1, '2001', 'nil'),
(2, '2002', 'nil'),
(3, '2003', 'nil'),
(4, '2004', 'nil'),
(5, '2005', 'nil'),
(6, '2006', 'nil'),
(7, '2007', 'nil'),
(8, '2008', 'nil'),
(9, '2009', 'nil'),
(10, '2010', 'nil'),
(11, '2011', 'nil');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
