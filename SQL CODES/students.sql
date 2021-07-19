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
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `student_id` int(11) NOT NULL,
  `mat_no` int(11) NOT NULL,
  `surname` text NOT NULL,
  `firstname` text NOT NULL,
  `other_names` text NOT NULL,
  `title` text NOT NULL,
  `dept_idr` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`student_id`, `mat_no`, `surname`, `firstname`, `other_names`, `title`, `dept_idr`) VALUES
(1, 601205, 'OSAZUWA', 'GENESIS', 'NIL', 'MISS', '1'),
(2, 601206, 'NATHANIEL', 'EODUS', 'NIL', 'MR', '1'),
(3, 601207, 'OBAKPOLOR12', 'LEVETICU', 'NIL', 'MISS', '1'),
(4, 601208, 'BAKPOLOR', 'NUMBERS', 'NIL', 'MR', '1'),
(5, 601209, 'MICHEAL', 'DETRONOMY ', 'NIL', 'MISS', '1'),
(6, 601210, 'DAISY', 'JOSHUA', 'NIL', 'MR', '1'),
(7, 601211, 'JOSEPH', 'OHN ', 'NIL', 'MISS', '1'),
(8, 601212, 'JOHN', 'ZACHARIAH ', 'NIL', 'MR', '1'),
(9, 601213, 'MATTHEW', 'SAMUEL ', 'NIL', 'MISS', '1'),
(10, 601214, 'MUSK', 'SMUELS ', 'NIL', 'MR', '1'),
(11, 601215, 'STEPHEN', 'FIKING ', 'NIL', 'MISS', '1'),
(12, 601216, 'STEPHAN', 'SEKING ', 'NIL', 'MR', '1'),
(13, 601217, 'STEVE', 'CHRONICLES ', 'NIL', 'MISS', '1'),
(14, 601218, 'ARESE', 'SCHRONICLES', 'NIL', 'MR', '1'),
(15, 601219, 'VICTOR', 'EZRA ', 'NIL', 'MISS', '1'),
(16, 601220, 'FUMNANYA', 'NEHEMIAH ', 'NIL', 'MR', '1'),
(17, 601221, 'IZIAH', 'PSALMS ', 'NIL', 'MISS', '1'),
(18, 601222, 'OSAMU', 'PROVERBS ', 'NIL', 'MR', '1'),
(19, 601223, 'IWINOSA', 'ZACHARIAH ', 'NIL', 'MISS', '1'),
(20, 601224, 'DANIEL', 'MALACHI ', 'NIL', 'MR', '1'),
(21, 601225, 'WILFRED', 'INGENIUM', 'NIL', 'MISS', '1'),
(22, 601226, 'OMO', 'DEKU ', 'NIL', 'MR', '1'),
(23, 601227, 'JOJO', 'OSARU ', 'NIL', 'MISS', '1'),
(24, 601228, 'TRAXX', 'OSARO ', 'NIL', 'MR', '1'),
(25, 601229, 'EPHRAIM', 'DRAKE ', 'NIL', 'MISS', '1'),
(26, 601230, 'GABRIEL', 'JOHN ', 'NIL', 'MR', '1'),
(27, 601231, 'OPTIMUS', 'WILLIAM ', 'NIL', 'MISS', '1'),
(28, 601232, 'MAXIMUS', 'SMITH', 'NIL', 'MR', '1'),
(29, 601233, 'VINCENT', 'PHILLIP', 'NIL', 'MISS', '1'),
(30, 601234, 'EWE', 'ANDREW ', 'NIL', 'MR', '1'),
(31, 601235, 'BORN', 'JAMES ', 'NIL', 'MISS', '1'),
(32, 601236, 'TRYBE', 'OBAN ', 'NIL', 'MR', '1'),
(33, 601237, 'SHALLOW', 'EDDY ', 'NIL', 'MISS', '1'),
(34, 601238, 'MAXIMILLIAN', 'MIRACLE ', 'NIL', 'MR', '1'),
(35, 601239, 'MIN', 'MYKAEL ', 'NIL', 'MISS', '1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`student_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
