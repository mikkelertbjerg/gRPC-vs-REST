-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Vært: mysql50.unoeuro.com
-- Genereringstid: 05. 12 2019 kl. 11:56:44
-- Serverversion: 5.7.28-31-log
-- PHP-version: 7.2.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mikkelertbjerg_dk_db_ls`
--

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `Depth_One`
--

CREATE TABLE `Depth_One` (
  `id` int(6) UNSIGNED NOT NULL,
  `string_value` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `int_value` int(50) NOT NULL,
  `double_value` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Data dump for tabellen `Depth_One`
--

INSERT INTO `Depth_One` (`id`, `string_value`, `int_value`, `double_value`) VALUES
(1, 'laoreet ipsum. Curabitur consequat,', 56420, 25778),
(2, 'urna suscipit nonummy. Fusce', 85867, 12353),
(3, 'at, velit. Pellentesque ultricies', 61386, 76626),
(4, 'cubilia Curae; Phasellus ornare.', 75925, 58164),
(5, 'suscipit nonummy. Fusce fermentum', 42725, 13033),
(6, 'magnis dis parturient montes,', 49537, 72129),
(7, 'Suspendisse ac metus vitae', 59053, 4478),
(8, 'risus. Donec egestas. Aliquam', 66172, 54344),
(9, 'Donec est. Nunc ullamcorper,', 39019, 68860),
(10, 'tellus faucibus leo, in', 30855, 85900),
(11, 'ultrices posuere cubilia Curae;', 52171, 17858),
(12, 'egestas. Fusce aliquet magna', 33003, 63365),
(13, 'a odio semper cursus.', 99912, 22649),
(14, 'cursus, diam at pretium', 77972, 91413),
(15, 'Duis at lacus. Quisque', 51312, 41738),
(16, 'aliquam eu, accumsan sed,', 91465, 31286),
(17, 'et, commodo at, libero.', 99488, 32631),
(18, 'ipsum non arcu. Vivamus', 32510, 13797),
(19, 'Lorem ipsum dolor sit', 68534, 57537),
(20, 'Vivamus rhoncus. Donec est.', 81328, 8258),
(21, 'adipiscing elit. Curabitur sed', 99565, 64601),
(22, 'dictum eu, eleifend nec,', 30966, 41434),
(23, 'Praesent eu nulla at', 19891, 32902),
(24, 'volutpat. Nulla dignissim. Maecenas', 56716, 66718),
(25, 'ornare tortor at risus.', 68340, 31917),
(26, 'senectus et netus et', 62494, 23466),
(27, 'gravida nunc sed pede.', 54023, 74915),
(28, 'neque pellentesque massa lobortis', 24442, 27753),
(29, 'mus. Donec dignissim magna', 95505, 80929),
(30, 'ornare, elit elit fermentum', 38267, 87159),
(31, 'urna, nec luctus felis', 4745, 64375),
(32, 'Praesent eu dui. Cum', 47204, 44668),
(33, 'nec tellus. Nunc lectus', 25725, 37325),
(34, 'mattis semper, dui lectus', 58830, 82436),
(35, 'libero est, congue a,', 73868, 9535),
(36, 'volutpat. Nulla facilisis. Suspendisse', 87630, 35600),
(37, 'cubilia Curae; Donec tincidunt.', 65964, 85749),
(38, 'tempus eu, ligula. Aenean', 97070, 13324),
(39, 'ullamcorper magna. Sed eu', 78793, 86050),
(40, 'lacinia mattis. Integer eu', 38612, 94938),
(41, 'Aliquam adipiscing lobortis risus.', 17409, 39379),
(42, 'at lacus. Quisque purus', 33346, 71008),
(43, 'libero. Morbi accumsan laoreet', 29362, 10490),
(44, 'nisl elementum purus, accumsan', 68871, 6364),
(45, 'est ac mattis semper,', 34619, 61736),
(46, 'Nullam scelerisque neque sed', 38797, 16700),
(47, 'scelerisque scelerisque dui. Suspendisse', 3233, 86749),
(48, 'ipsum nunc id enim.', 28223, 10841),
(49, 'non enim. Mauris quis', 21459, 26107),
(50, 'Sed malesuada augue ut', 51624, 62463),
(51, 'pede. Praesent eu dui.', 75679, 61403),
(52, 'Curabitur ut odio vel', 94842, 8269),
(53, 'rutrum, justo. Praesent luctus.', 26585, 51200),
(54, 'sed leo. Cras vehicula', 23252, 84786),
(55, 'scelerisque neque. Nullam nisl.', 20607, 46948),
(56, 'eu sem. Pellentesque ut', 74323, 95217),
(57, 'cursus purus. Nullam scelerisque', 60759, 79843),
(58, 'fringilla cursus purus. Nullam', 6962, 58789),
(59, 'Vivamus sit amet risus.', 10075, 42561),
(60, 'id, mollis nec, cursus', 12028, 13363),
(61, 'tellus, imperdiet non, vestibulum', 81968, 21271),
(62, 'dapibus id, blandit at,', 38313, 90577),
(63, 'libero. Proin sed turpis', 89468, 31975),
(64, 'aliquet, sem ut cursus', 36436, 76146),
(65, 'imperdiet non, vestibulum nec,', 47651, 43311),
(66, 'sodales. Mauris blandit enim', 31372, 96355),
(67, 'Suspendisse tristique neque venenatis', 95706, 74867),
(68, 'felis orci, adipiscing non,', 17088, 59821),
(69, 'lorem eu metus. In', 10033, 2240),
(70, 'in faucibus orci luctus', 85932, 76199),
(71, 'ornare lectus justo eu', 33698, 5030),
(72, 'In at pede. Cras', 79526, 32987),
(73, 'posuere cubilia Curae; Donec', 26543, 51156),
(74, 'euismod et, commodo at,', 62318, 55411),
(75, 'sem ut dolor dapibus', 6669, 49115),
(76, 'scelerisque neque. Nullam nisl.', 60070, 20490),
(77, 'nec, leo. Morbi neque', 62361, 69715),
(78, 'risus varius orci, in', 53177, 9095),
(79, 'Suspendisse sed dolor. Fusce', 75745, 88055),
(80, 'eu nulla at sem', 19453, 64288),
(81, 'ac orci. Ut semper', 40257, 3382),
(82, 'nascetur ridiculus mus. Donec', 29904, 83578),
(83, 'orci, consectetuer euismod est', 82216, 37109),
(84, 'aliquam eu, accumsan sed,', 42354, 55166),
(85, 'bibendum sed, est. Nunc', 68454, 52827),
(86, 'aliquam, enim nec tempus', 87544, 78455),
(87, 'Proin non massa non', 83409, 83052),
(88, 'justo. Praesent luctus. Curabitur', 46650, 59643),
(89, 'sagittis. Nullam vitae diam.', 15137, 25269),
(90, 'urna et arcu imperdiet', 30962, 2641),
(91, 'sed, sapien. Nunc pulvinar', 9431, 88036),
(92, 'vulputate mauris sagittis placerat.', 21155, 80375),
(93, 'venenatis vel, faucibus id,', 63216, 61737),
(94, 'amet orci. Ut sagittis', 88633, 37763),
(95, 'magna a neque. Nullam', 25040, 57872),
(96, 'Nullam scelerisque neque sed', 37072, 33322),
(97, 'ligula eu enim. Etiam', 37415, 93528),
(98, 'mauris ipsum porta elit,', 52396, 63362),
(99, 'ornare egestas ligula. Nullam', 35785, 8966),
(100, 'convallis erat, eget tincidunt', 66705, 99856);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `Depth_One`
--
ALTER TABLE `Depth_One`
  ADD PRIMARY KEY (`id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `Depth_One`
--
ALTER TABLE `Depth_One`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
