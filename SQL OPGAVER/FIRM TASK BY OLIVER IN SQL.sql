-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 29. 11 2019 kl. 11:55:38
-- Serverversion: 10.4.8-MariaDB
-- PHP-version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `linuxuslesstechtips`
--

DELIMITER $$
--
-- Procedurer
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteChosenEmployee` (IN `DeleteUserID` INT(11))  BEGIN
	DELETE FROM employees WHERE employee_ID = DeleteUserID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GetSpecifikEmployeeSalary` (IN `employeeSalary` INT(11))  BEGIN

	SELECT employees.*, salaries.salary_Amount
	FROM employees
	INNER JOIN salaries
	ON employees.employee_ID = salaries.employee_ID
	WHERE employees.employee_ID = employeeSalary;

END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `allemployees`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `allemployees` (
`employee_Firstname` varchar(255)
);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `departments`
--

CREATE TABLE `departments` (
  `dep_Name` varchar(255) NOT NULL,
  `dep_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `departments`
--

INSERT INTO `departments` (`dep_Name`, `dep_ID`) VALUES
('Cleaning', 1),
('Storage', 2),
('Backupping', 3),
('Managing', 4),
('Administering', 5);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `dep_employee`
--

CREATE TABLE `dep_employee` (
  `dep_ID` int(255) NOT NULL,
  `employee_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `dep_manager`
--

CREATE TABLE `dep_manager` (
  `dep_Name` varchar(255) NOT NULL,
  `employee_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `employees`
--

CREATE TABLE `employees` (
  `employee_ID` int(11) NOT NULL,
  `employee_Firstname` varchar(255) DEFAULT NULL,
  `employee_Lastname` varchar(255) DEFAULT NULL,
  `employee_Email` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `employees`
--

INSERT INTO `employees` (`employee_ID`, `employee_Firstname`, `employee_Lastname`, `employee_Email`) VALUES
(1, 'Oliver', 'Olesen', 'oliver.ian.o@hotmail.com'),
(2, 'Kasper', 'Hansen', 'KasperHansen@hotmail.com'),
(3, 'Jhon', 'Sørensen', 'JhonSørensen@hotmail.com'),
(5, 'Poul', 'Andersen', 'PoulAndersen@hotmail.com'),
(6, 'Anders', 'Ludvigsen', 'AndersLudvigsen@hotmail.com');

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `employee_id2salary`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `employee_id2salary` (
`employee_ID` int(11)
,`employee_Firstname` varchar(255)
,`employee_Lastname` varchar(255)
,`employee_Email` varchar(255)
,`salary_Amount` int(11)
);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `salaries`
--

CREATE TABLE `salaries` (
  `salary_Amount` int(11) NOT NULL,
  `employee_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `salaries`
--

INSERT INTO `salaries` (`salary_Amount`, `employee_ID`) VALUES
(8000, 1),
(9000, 2),
(2000, 3),
(85000, 5),
(2000, 6);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `titles`
--

CREATE TABLE `titles` (
  `Title_Name` varchar(255) NOT NULL,
  `employee_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `titles`
--

INSERT INTO `titles` (`Title_Name`, `employee_ID`) VALUES
('Employee', 1),
('Employee', 2),
('Employee', 3),
('manager', 5),
('CEO', 6);

-- --------------------------------------------------------

--
-- Struktur for visning `allemployees`
--
DROP TABLE IF EXISTS `allemployees`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `allemployees`  AS  select `employees`.`employee_Firstname` AS `employee_Firstname` from `employees` ;

-- --------------------------------------------------------

--
-- Struktur for visning `employee_id2salary`
--
DROP TABLE IF EXISTS `employee_id2salary`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `employee_id2salary`  AS  select `employees`.`employee_ID` AS `employee_ID`,`employees`.`employee_Firstname` AS `employee_Firstname`,`employees`.`employee_Lastname` AS `employee_Lastname`,`employees`.`employee_Email` AS `employee_Email`,`salaries`.`salary_Amount` AS `salary_Amount` from (`employees` join `salaries` on(`employees`.`employee_ID` = `salaries`.`employee_ID`)) where `employees`.`employee_ID` = 2 ;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`dep_ID`);

--
-- Indeks for tabel `dep_employee`
--
ALTER TABLE `dep_employee`
  ADD KEY `employee_ID` (`employee_ID`),
  ADD KEY `dep_ID` (`dep_ID`);

--
-- Indeks for tabel `dep_manager`
--
ALTER TABLE `dep_manager`
  ADD KEY `employee_ID` (`employee_ID`);

--
-- Indeks for tabel `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`employee_ID`);

--
-- Indeks for tabel `salaries`
--
ALTER TABLE `salaries`
  ADD KEY `employee_ID` (`employee_ID`);

--
-- Indeks for tabel `titles`
--
ALTER TABLE `titles`
  ADD KEY `employee_ID` (`employee_ID`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `departments`
--
ALTER TABLE `departments`
  MODIFY `dep_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tilføj AUTO_INCREMENT i tabel `employees`
--
ALTER TABLE `employees`
  MODIFY `employee_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `dep_employee`
--
ALTER TABLE `dep_employee`
  ADD CONSTRAINT `dep_employee_ibfk_1` FOREIGN KEY (`employee_ID`) REFERENCES `employees` (`employee_ID`) ON DELETE CASCADE,
  ADD CONSTRAINT `dep_employee_ibfk_2` FOREIGN KEY (`dep_ID`) REFERENCES `departments` (`dep_ID`);

--
-- Begrænsninger for tabel `dep_manager`
--
ALTER TABLE `dep_manager`
  ADD CONSTRAINT `dep_manager_ibfk_1` FOREIGN KEY (`employee_ID`) REFERENCES `employees` (`employee_ID`) ON DELETE CASCADE;

--
-- Begrænsninger for tabel `salaries`
--
ALTER TABLE `salaries`
  ADD CONSTRAINT `salaries_ibfk_1` FOREIGN KEY (`employee_ID`) REFERENCES `employees` (`employee_ID`) ON DELETE CASCADE;

--
-- Begrænsninger for tabel `titles`
--
ALTER TABLE `titles`
  ADD CONSTRAINT `titles_ibfk_1` FOREIGN KEY (`employee_ID`) REFERENCES `employees` (`employee_ID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
