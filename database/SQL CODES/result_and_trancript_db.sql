-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 19, 2021 at 06:29 PM
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

-- --------------------------------------------------------

--
-- Table structure for table `results`
--

CREATE TABLE `results` (
  `result_id` int(11) NOT NULL,
  `s_n` int(11) NOT NULL,
  `student_idr` int(11) NOT NULL,
  `ca` int(11) NOT NULL,
  `exam` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `rules` varchar(100) NOT NULL,
  `course_idr` int(11) NOT NULL,
  `session_idr` int(11) NOT NULL,
  `department_idr` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `results`
--

INSERT INTO `results` (`result_id`, `s_n`, `student_idr`, `ca`, `exam`, `total`, `rules`, `course_idr`, `session_idr`, `department_idr`) VALUES
(1, 1, 901012, 4, 46, 50, '1', 1, 1, 1),
(1, 2, 901013, 10, 66, 76, '1', 1, 1, 1),
(1, 3, 901014, 5, 54, 59, '1', 1, 1, 1),
(1, 4, 901015, 8, 12, 20, '1', 1, 1, 1),
(1, 5, 901016, 6, 56, 62, '1', 1, 1, 1),
(1, 6, 901017, 12, 34, 46, '1', 1, 1, 1),
(1, 7, 901018, 6, 45, 51, '1', 1, 1, 1),
(1, 8, 901019, 5, 66, 71, '1', 1, 1, 1),
(1, 9, 901020, 0, 14, 14, '1', 1, 1, 1),
(1, 10, 901021, 0, 44, 44, '1', 1, 1, 1),
(1, 11, 901022, 11, 55, 66, '1', 1, 1, 1),
(1, 12, 901023, 2, 67, 69, '1', 1, 1, 1),
(1, 13, 901024, 13, 65, 78, '1', 1, 1, 1),
(1, 14, 901025, 0, 34, 34, '1', 1, 1, 1),
(1, 15, 901026, 0, 43, 43, '1', 1, 1, 1),
(1, 16, 901027, 9, 23, 32, '1', 1, 1, 1),
(1, 17, 901028, 2, 53, 55, '1', 1, 1, 1),
(1, 18, 901029, 6, 34, 40, '1', 1, 1, 1),
(1, 19, 901030, 8, 45, 53, '1', 1, 1, 1),
(1, 20, 901031, 9, 65, 74, '1', 1, 1, 1),
(1, 21, 901032, 0, 15, 15, '1', 1, 1, 1),
(1, 22, 901033, 12, 53, 65, '1', 1, 1, 1),
(1, 23, 901034, 8, 34, 42, '1', 1, 1, 1),
(1, 24, 901035, 6, 45, 51, '1', 1, 1, 1),
(1, 25, 901036, 0, 65, 65, '1', 1, 1, 1),
(1, 26, 901037, 7, 15, 22, '1', 1, 1, 1),
(1, 27, 901038, 11, 53, 64, '1', 1, 1, 1),
(1, 28, 901039, 13, 34, 47, '1', 1, 1, 1),
(1, 29, 901040, 0, 45, 45, '1', 1, 1, 1),
(1, 30, 901041, 10, 65, 75, '1', 1, 1, 1),
(1, 31, 901042, 0, 15, 15, '1', 1, 1, 1),
(1, 32, 901043, 5, 53, 58, '1', 1, 1, 1),
(1, 33, 901044, 7, 34, 41, '1', 1, 1, 1),
(1, 34, 901045, 6, 45, 51, '1', 1, 1, 1),
(1, 35, 901046, 11, 65, 76, '1', 1, 1, 1),
(1, 36, 901047, 11, 15, 26, '1', 1, 1, 1),
(1, 37, 901048, 8, 53, 61, '1', 1, 1, 1),
(1, 38, 901049, 3, 34, 37, '1', 1, 1, 1),
(1, 39, 901050, 3, 45, 48, '1', 1, 1, 1),
(1, 40, 901051, 6, 65, 71, '1', 1, 1, 1),
(1, 41, 901052, 5, 15, 20, '1', 1, 1, 1),
(1, 42, 901053, 8, 53, 61, '1', 1, 1, 1),
(1, 43, 901054, 13, 34, 47, '1', 1, 1, 1),
(1, 44, 901055, 12, 45, 57, '1', 1, 1, 1),
(1, 45, 901056, 4, 65, 69, '1', 1, 1, 1),
(1, 46, 901057, 5, 15, 20, '1', 1, 1, 1),
(1, 47, 901058, 3, 34, 37, '1', 1, 1, 1),
(1, 48, 901059, 10, 45, 55, '1', 1, 1, 1),
(1, 49, 901060, 3, 65, 68, '1', 1, 1, 1),
(1, 59, 901061, 0, 15, 15, '1', 1, 1, 1),
(1, 50, 901062, 7, 53, 60, '1', 1, 1, 1),
(1, 51, 901063, 9, 34, 43, '1', 1, 1, 1),
(1, 53, 901064, 10, 45, 55, '1', 1, 1, 1),
(1, 54, 901065, 11, 65, 76, '1', 1, 1, 1),
(1, 55, 901066, 3, 15, 18, '1', 1, 1, 1),
(1, 56, 901067, 0, 13, 13, '1', 1, 1, 1),
(1, 57, 901068, 6, 34, 40, '1', 1, 1, 1),
(1, 58, 901069, 0, 45, 45, '1', 1, 1, 1),
(1, 59, 901070, 4, 65, 69, '1', 1, 1, 1),
(1, 60, 901071, 6, 15, 21, '1', 1, 1, 1),
(1, 61, 901072, 4, 53, 57, '1', 1, 1, 1),
(1, 62, 901073, 0, 34, 34, '1', 1, 1, 1),
(1, 63, 901074, 0, 45, 45, '1', 1, 1, 1),
(1, 64, 901075, 12, 65, 77, '1', 1, 1, 1),
(1, 65, 901076, 14, 15, 29, '1', 1, 1, 1),
(1, 66, 901077, 3, 53, 56, '1', 1, 1, 1),
(1, 67, 901078, 0, 34, 34, '1', 1, 1, 1),
(1, 68, 901079, 6, 45, 51, '1', 1, 1, 1),
(1, 69, 901080, 9, 65, 74, '1', 1, 1, 1),
(1, 70, 901081, 2, 15, 17, '1', 1, 1, 1),
(1, 71, 901082, 7, 65, 72, '1', 1, 1, 1),
(1, 72, 901083, 8, 15, 23, '1', 1, 1, 1),
(1, 73, 901084, 8, 65, 73, '1', 1, 1, 1),
(1, 74, 901085, 4, 15, 19, '1', 1, 1, 1);

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
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(191) DEFAULT NULL,
  `email` varchar(191) NOT NULL,
  `password` varchar(191) NOT NULL,
  `activation_code` varchar(191) DEFAULT NULL,
  `persist_code` varchar(191) DEFAULT NULL,
  `reset_password_code` varchar(191) DEFAULT NULL,
  `permissions` text,
  `is_activated` tinyint(1) NOT NULL DEFAULT '0',
  `activated_at` timestamp NULL DEFAULT NULL,
  `last_login` timestamp NULL DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `username` varchar(191) DEFAULT NULL,
  `surname` varchar(191) DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL,
  `last_seen` timestamp NULL DEFAULT NULL,
  `is_guest` tinyint(1) NOT NULL DEFAULT '0',
  `is_superuser` tinyint(1) NOT NULL DEFAULT '0',
  `gender` varchar(6) DEFAULT NULL,
  `mobile` varchar(50) DEFAULT NULL,
  `accept_terms` tinyint(1) NOT NULL DEFAULT '0',
  `country_name` varchar(100) DEFAULT NULL,
  `country_iso_code` varchar(50) DEFAULT NULL,
  `created_ip_address` varchar(255) DEFAULT NULL,
  `last_ip_address` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  UNIQUE KEY `users_email_unique` (`email`) USING BTREE,
  UNIQUE KEY `users_login_unique` (`username`) USING BTREE,
  KEY `users_activation_code_index` (`activation_code`) USING BTREE,
  KEY `users_reset_password_code_index` (`reset_password_code`) USING BTREE,
  KEY `users_login_index` (`username`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','admin@gmail.com','$2y$10$randomhashedandencryptnWTlhVL0O',NULL,'$2y$10$randomhashedandencryptnWTlhVL0OQeqKNLq.rXOWDJCe',NULL,NULL,1,'2019-12-30 21:59:52','2020-05-22 11:03:38','2019-12-30 21:49:14','2020-05-22 11:03:38','Admin','Surname',NULL,'2020-05-23 07:06:54',0,0,'Male','+2348105447111',1,'Nigeria','ng',NULL,'105.112.97.230')/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;


--
-- Indexes for dumped tables
--

--
-- Indexes for table `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`dept_id`);

--
-- Indexes for table `results`
--
ALTER TABLE `results`
  ADD PRIMARY KEY (`student_idr`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`student_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
