-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Vært: mysql50.unoeuro.com
-- Genereringstid: 05. 12 2019 kl. 11:58:49
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
-- Struktur-dump for tabellen `Depth_Eight`
--

CREATE TABLE `Depth_Eight` (
  `id` int(6) UNSIGNED NOT NULL,
  `string_value` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `int_value` int(50) NOT NULL,
  `double_value` double NOT NULL,
  `depth_seven_id` int(6) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Data dump for tabellen `Depth_Eight`
--

INSERT INTO `Depth_Eight` (`id`, `string_value`, `int_value`, `double_value`, `depth_seven_id`) VALUES
(1, 'rhoncus id, mollis nec,', 30922, 90861, 29),
(2, 'odio. Aliquam vulputate ullamcorper', 67986, 57822, 24),
(3, 'Suspendisse non leo. Vivamus', 60860, 96923, 93),
(4, 'amet risus. Donec egestas.', 50650, 72631, 94),
(5, 'quam vel sapien imperdiet', 17368, 3397, 40),
(6, 'lectus. Nullam suscipit, est', 39901, 85344, 62),
(7, 'eu turpis. Nulla aliquet.', 3476, 98953, 22),
(8, 'dictum sapien. Aenean massa.', 70600, 52202, 91),
(9, 'laoreet ipsum. Curabitur consequat,', 40636, 14047, 47),
(10, 'neque non quam. Pellentesque', 65591, 81598, 95),
(11, 'consequat nec, mollis vitae,', 31997, 72956, 63),
(12, 'sit amet, faucibus ut,', 8698, 77959, 2),
(13, 'arcu. Curabitur ut odio', 2928, 25507, 94),
(14, 'dictum. Proin eget odio.', 56399, 87386, 86),
(15, 'blandit viverra. Donec tempus,', 58529, 14637, 10),
(16, 'Fusce fermentum fermentum arcu.', 76466, 54896, 63),
(17, 'aliquet nec, imperdiet nec,', 58859, 24393, 8),
(18, 'eros. Nam consequat dolor', 61338, 57354, 21),
(19, 'hymenaeos. Mauris ut quam', 95818, 6025, 10),
(20, 'tempus eu, ligula. Aenean', 38225, 16327, 19),
(21, 'Donec nibh. Quisque nonummy', 76294, 84892, 49),
(22, 'dolor. Fusce mi lorem,', 62230, 3260, 19),
(23, 'elit, dictum eu, eleifend', 49788, 33384, 68),
(24, 'ac mi eleifend egestas.', 64821, 86256, 92),
(25, 'facilisis. Suspendisse commodo tincidunt', 91996, 22631, 80),
(26, 'dignissim lacus. Aliquam rutrum', 35830, 63246, 65),
(27, 'ac mi eleifend egestas.', 18757, 25978, 86),
(28, 'non, bibendum sed, est.', 5995, 51663, 40),
(29, 'metus. In lorem. Donec', 54879, 21979, 61),
(30, 'aliquet vel, vulputate eu,', 74256, 63188, 45),
(31, 'Aenean eget metus. In', 96371, 9648, 57),
(32, 'auctor quis, tristique ac,', 76337, 39254, 39),
(33, 'facilisis non, bibendum sed,', 46745, 47895, 70),
(34, 'commodo auctor velit. Aliquam', 89811, 37915, 53),
(35, 'eros. Proin ultrices. Duis', 18723, 63112, 14),
(36, 'ut aliquam iaculis, lacus', 43922, 53800, 72),
(37, 'montes, nascetur ridiculus mus.', 11166, 61243, 3),
(38, 'habitant morbi tristique senectus', 85938, 49864, 50),
(39, 'est mauris, rhoncus id,', 89622, 12241, 63),
(40, 'Cras eget nisi dictum', 72172, 65494, 82),
(41, 'adipiscing lobortis risus. In', 26998, 29748, 40),
(42, 'lacus pede sagittis augue,', 87871, 36973, 1),
(43, 'ipsum. Phasellus vitae mauris', 80097, 86612, 65),
(44, 'aliquet odio. Etiam ligula', 89786, 55680, 14),
(45, 'mauris eu elit. Nulla', 54787, 55654, 77),
(46, 'Duis gravida. Praesent eu', 5751, 53811, 10),
(47, 'vehicula. Pellentesque tincidunt tempus', 7522, 53465, 83),
(48, 'faucibus orci luctus et', 67271, 96367, 63),
(49, 'id, erat. Etiam vestibulum', 24014, 78662, 98),
(50, 'mattis velit justo nec', 21725, 50342, 43),
(51, 'Duis dignissim tempor arcu.', 44151, 33347, 72),
(52, 'et nunc. Quisque ornare', 96913, 38478, 16),
(53, 'velit. Pellentesque ultricies dignissim', 67733, 24067, 21),
(54, 'vulputate velit eu sem.', 65105, 69271, 28),
(55, 'lobortis ultrices. Vivamus rhoncus.', 10438, 25607, 3),
(56, 'enim. Sed nulla ante,', 82095, 20253, 76),
(57, 'Nunc lectus pede, ultrices', 90169, 59268, 70),
(58, 'lacus. Etiam bibendum fermentum', 44355, 36017, 21),
(59, 'luctus vulputate, nisi sem', 73428, 23639, 36),
(60, 'ultricies ornare, elit elit', 68068, 79673, 1),
(61, 'tristique senectus et netus', 51035, 11268, 43),
(62, 'at, nisi. Cum sociis', 68421, 18543, 25),
(63, 'a, arcu. Sed et', 10665, 84072, 53),
(64, 'eget, dictum placerat, augue.', 20691, 36712, 24),
(65, 'vitae risus. Duis a', 29861, 32908, 100),
(66, 'mauris, rhoncus id, mollis', 94254, 92423, 79),
(67, 'magna a tortor. Nunc', 97074, 45945, 72),
(68, 'neque. Nullam nisl. Maecenas', 73157, 96669, 42),
(69, 'metus. Vivamus euismod urna.', 58823, 83064, 3),
(70, 'auctor velit. Aliquam nisl.', 79368, 52252, 89),
(71, 'orci luctus et ultrices', 51179, 75485, 72),
(72, 'Curabitur massa. Vestibulum accumsan', 31593, 22248, 11),
(73, 'vulputate, risus a ultricies', 34866, 73648, 34),
(74, 'elementum at, egestas a,', 44385, 13978, 24),
(75, 'In tincidunt congue turpis.', 14408, 20066, 78),
(76, 'a, facilisis non, bibendum', 10508, 71151, 20),
(77, 'Quisque porttitor eros nec', 31244, 44102, 17),
(78, 'feugiat non, lobortis quis,', 73992, 17884, 21),
(79, 'pede, nonummy ut, molestie', 28729, 90225, 9),
(80, 'Quisque ac libero nec', 89367, 54085, 30),
(81, 'ligula. Aliquam erat volutpat.', 21044, 94840, 85),
(82, 'dolor quam, elementum at,', 3499, 90630, 64),
(83, 'vitae risus. Duis a', 9824, 32686, 50),
(84, 'Donec fringilla. Donec feugiat', 84512, 23518, 68),
(85, 'eget, dictum placerat, augue.', 55217, 80858, 38),
(86, 'augue eu tellus. Phasellus', 19542, 55479, 99),
(87, 'libero est, congue a,', 95868, 84803, 78),
(88, 'Quisque imperdiet, erat nonummy', 19136, 27609, 26),
(89, 'est tempor bibendum. Donec', 21547, 77701, 15),
(90, 'Lorem ipsum dolor sit', 62847, 19998, 31),
(91, 'Mauris blandit enim consequat', 4116, 10627, 85),
(92, 'vitae, sodales at, velit.', 91614, 12404, 92),
(93, 'ante bibendum ullamcorper. Duis', 14690, 55357, 22),
(94, 'ante. Nunc mauris sapien,', 55630, 10522, 78),
(95, 'cubilia Curae; Phasellus ornare.', 72402, 34102, 92),
(96, 'Morbi vehicula. Pellentesque tincidunt', 24608, 82601, 4),
(97, 'In at pede. Cras', 1114, 2937, 62),
(98, 'magnis dis parturient montes,', 69991, 57556, 6),
(99, 'vel pede blandit congue.', 6382, 90617, 46),
(100, 'Curabitur egestas nunc sed', 69875, 9714, 15);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `Depth_Eight`
--
ALTER TABLE `Depth_Eight`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_depth_seven` (`depth_seven_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `Depth_Eight`
--
ALTER TABLE `Depth_Eight`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `Depth_Eight`
--
ALTER TABLE `Depth_Eight`
  ADD CONSTRAINT `fk_depth_seven` FOREIGN KEY (`depth_seven_id`) REFERENCES `Depth_Seven` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
