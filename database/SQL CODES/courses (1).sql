-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 19, 2021 at 06:32 PM
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
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `course_id` int(11) NOT NULL,
  `course_code` text NOT NULL,
  `course_title` text NOT NULL,
  `semester` int(11) NOT NULL,
  `units` int(11) NOT NULL,
  `level` varchar(5) NOT NULL,
  `department` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`course_id`, `course_code`, `course_title`, `semester`, `units`, `level`, `department`) VALUES
(1, 'CPE300', '2', 0, 1, '300', 'Computer Engineering'),
(2, 'CPE302', '2', 0, 2, '300', 'Computer Engineering'),
(3, 'CPE304', '1', 0, 2, '300', 'Computer Engineering'),
(4, 'CPE311', '3', 0, 1, '300', 'Computer Engineering'),
(5, 'CPE312', '3', 0, 2, '300', 'Computer Engineering'),
(6, 'CPE313', '2', 0, 1, '300', 'Computer Engineering'),
(7, 'CPE314', '3', 0, 2, '300', 'Computer Engineering'),
(8, 'CPE316', '3', 0, 2, '300', 'Computer Engineering'),
(9, 'CPE321', '2', 0, 1, '300', 'Computer Engineering'),
(10, 'CPE322', '3', 0, 2, '300', 'Computer Engineering'),
(11, 'CPE324', '2', 0, 2, '300', 'Computer Engineering'),
(12, 'CPE371', '3', 0, 1, '300', 'Computer Engineering'),
(13, 'CPE372', '3', 0, 2, '300', 'Computer Engineering'),
(14, 'CPE375', '3', 0, 1, '300', 'Computer Engineering'),
(15, 'CPE376', '3', 0, 2, '300', 'Computer Engineering'),
(16, 'CPE377', '3', 0, 1, '300', 'Computer Engineering'),
(17, 'CPE378', '3', 0, 2, '300', 'Computer Engineering'),
(18, 'CPE382', '3', 0, 2, '300', 'Computer Engineering'),
(19, 'CPE399', '2', 0, 2, '300', 'Computer Engineering'),
(20, 'CPE423', '3', 0, 1, '400', 'Computer Engineering'),
(21, 'CPE451', '3', 0, 1, '400', 'Computer Engineering'),
(22, 'CPE457', '3', 0, 1, '400', 'Computer Engineering'),
(23, 'CPE471', '3', 0, 1, '400', 'Computer Engineering'),
(24, 'CPE473', '3', 0, 1, '400', 'Computer Engineering'),
(25, 'CPE475', '3', 0, 1, '400', 'Computer Engineering'),
(26, 'CPE477', '3', 0, 1, '400', 'Computer Engineering'),
(27, 'CPE481', '3', 0, 1, '400', 'Computer Engineering'),
(28, 'CPE500', '6', 0, 1, '500', 'Computer Engineering'),
(29, 'CPE501', '3', 0, 1, '500', 'Computer Engineering'),
(30, 'CPE502', '3', 0, 2, '500', 'Computer Engineering'),
(31, 'CPE512', '3', 0, 2, '500', 'Computer Engineering'),
(32, 'CPE522', '3', 0, 2, '500', 'Computer Engineering'),
(33, 'CPE534', '3', 0, 2, '500', 'Computer Engineering'),
(34, 'CPE552', '3', 0, 2, '500', 'Computer Engineering'),
(35, 'CPE553', '3', 0, 1, '500', 'Computer Engineering'),
(36, 'CPE554', '3', 0, 2, '500', 'Computer Engineering'),
(37, 'CPE556', '3', 0, 2, '500', 'Computer Engineering'),
(38, 'CPE571', '3', 0, 1, '500', 'Computer Engineering'),
(39, 'CPE573', '3', 0, 1, '500', 'Computer Engineering'),
(40, 'CPE574', '3', 0, 2, '500', 'Computer Engineering'),
(41, 'CPE575', '3', 0, 1, '500', 'Computer Engineering'),
(42, 'CPE576', '3', 0, 2, '500', 'Computer Engineering'),
(43, 'CPE577', '3', 0, 1, '500', 'Computer Engineering'),
(44, 'CPE578', '3', 0, 2, '500', 'Computer Engineering'),
(45, 'CPE590', '0', 0, 2, '500', 'Computer Engineering'),
(46, 'CPE591', '3', 0, 1, '500', 'Computer Engineering');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
