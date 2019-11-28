-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 28. 11 2019 kl. 13:51:05
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
  `dep_Name` varchar(255) DEFAULT NULL,
  `dep_employee_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `dep_manager`
--

CREATE TABLE `dep_manager` (
  `managing_Department` varchar(255) DEFAULT NULL,
  `dep_employee_ID` int(11) DEFAULT NULL
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
(4, 'Bob', 'Poulsen', 'BobPoulsen@hotmail.com'),
(5, 'Poul', 'Andersen', 'PoulAndersen@hotmail.com'),
(6, 'Anders', 'Ludvigsen', 'AndersLudvigsen@hotmail.com');

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `salaries`
--

CREATE TABLE `salaries` (
  `salary_Amount` int(11) DEFAULT NULL,
  `salary_employee_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `salaries`
--

INSERT INTO `salaries` (`salary_Amount`, `salary_employee_ID`) VALUES
(8000, 1),
(9000, 2),
(2000, 3),
(3000, 4),
(85000, 5),
(2000, 6);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `titles`
--

CREATE TABLE `titles` (
  `Title_Name` varchar(255) DEFAULT NULL,
  `title_Employee_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `titles`
--

INSERT INTO `titles` (`Title_Name`, `title_Employee_ID`) VALUES
('Employee', 1),
('Employee', 2),
('Employee', 3),
('Administrator', 4),
('manager', 5),
('CEO', 6);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`dep_Name`),
  ADD UNIQUE KEY `dep_ID` (`dep_ID`);

--
-- Indeks for tabel `dep_employee`
--
ALTER TABLE `dep_employee`
  ADD KEY `dep_employee_ID` (`dep_employee_ID`),
  ADD KEY `dep_Name` (`dep_Name`);

--
-- Indeks for tabel `dep_manager`
--
ALTER TABLE `dep_manager`
  ADD KEY `dep_employee_ID` (`dep_employee_ID`);

--
-- Indeks for tabel `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`employee_ID`);

--
-- Indeks for tabel `salaries`
--
ALTER TABLE `salaries`
  ADD KEY `salary_employee_ID` (`salary_employee_ID`);

--
-- Indeks for tabel `titles`
--
ALTER TABLE `titles`
  ADD KEY `title_Employee_ID` (`title_Employee_ID`);

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
  ADD CONSTRAINT `dep_employee_ibfk_1` FOREIGN KEY (`dep_employee_ID`) REFERENCES `employees` (`employee_ID`),
  ADD CONSTRAINT `dep_employee_ibfk_2` FOREIGN KEY (`dep_Name`) REFERENCES `departments` (`dep_Name`);

--
-- Begrænsninger for tabel `dep_manager`
--
ALTER TABLE `dep_manager`
  ADD CONSTRAINT `dep_manager_ibfk_1` FOREIGN KEY (`dep_employee_ID`) REFERENCES `employees` (`employee_ID`);

--
-- Begrænsninger for tabel `salaries`
--
ALTER TABLE `salaries`
  ADD CONSTRAINT `salaries_ibfk_1` FOREIGN KEY (`salary_employee_ID`) REFERENCES `employees` (`employee_ID`);

--
-- Begrænsninger for tabel `titles`
--
ALTER TABLE `titles`
  ADD CONSTRAINT `titles_ibfk_1` FOREIGN KEY (`title_Employee_ID`) REFERENCES `employees` (`employee_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
