-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 19, 2021 at 06:35 PM
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
-- Table structure for table `departments`
--

CREATE TABLE `departments` (
  `dept_id` int(11) NOT NULL,
  `name` text NOT NULL,
  `faculty` text NOT NULL,
  `university` text NOT NULL,
  `comments` text NOT NULL,
  `sessions_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `departments`
--

INSERT INTO `departments` (`dept_id`, `name`, `faculty`, `university`, `comments`, `sessions_id`) VALUES
(1, 'Computer', 'ENG', 'UNIBEN', 'NIL', 0),
(2, 'Production', 'ENG', 'UNIBEN', 'NIL', 0),
(3, 'Chemical', 'ENG', 'UNIBEN', 'NIL', 0),
(4, 'Mechatronics', 'ENG', 'UNIBEN', 'NIL', 0),
(5, 'Electrical', 'ENG', 'UNIBEN', 'NIL', 0),
(6, 'Industrial', 'ENG', 'UNIBEN', 'NIL', 0),
(7, 'Marine', 'ENG', 'UNIBEN', 'NIL', 0),
(8, 'Mechanical', 'ENG', 'UNIBEN', 'NIL', 0),
(9, 'Agricultural', 'ENG', 'UNIBEN', 'NIL', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`dept_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
