-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Vært: mysql50.unoeuro.com
-- Genereringstid: 05. 12 2019 kl. 11:58:18
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
-- Struktur-dump for tabellen `Depth_Four`
--

CREATE TABLE `Depth_Four` (
  `id` int(6) UNSIGNED NOT NULL,
  `string_value` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `int_value` int(50) NOT NULL,
  `double_value` double NOT NULL,
  `depth_three_id` int(6) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Data dump for tabellen `Depth_Four`
--

INSERT INTO `Depth_Four` (`id`, `string_value`, `int_value`, `double_value`, `depth_three_id`) VALUES
(1, 'Integer vulputate, risus a', 14777, 39839, 57),
(2, 'orci, adipiscing non, luctus', 46361, 43854, 28),
(3, 'ut nisi a odio', 15976, 56958, 96),
(4, 'conubia nostra, per inceptos', 95621, 24028, 18),
(5, 'metus. In lorem. Donec', 54777, 80962, 63),
(6, 'velit. Sed malesuada augue', 65079, 26010, 1),
(7, 'egestas. Aliquam nec enim.', 83112, 5530, 100),
(8, 'Fusce dolor quam, elementum', 44675, 56582, 4),
(9, 'fermentum risus, at fringilla', 44507, 49585, 66),
(10, 'sociis natoque penatibus et', 68404, 19222, 82),
(11, 'dolor, nonummy ac, feugiat', 71775, 13761, 100),
(12, 'sem magna nec quam.', 42840, 87366, 16),
(13, 'ut odio vel est', 74343, 73808, 34),
(14, 'ultrices. Vivamus rhoncus. Donec', 71465, 43269, 66),
(15, 'facilisis eget, ipsum. Donec', 65329, 34267, 9),
(16, 'elit, pharetra ut, pharetra', 84349, 16520, 47),
(17, 'ullamcorper, nisl arcu iaculis', 78424, 25846, 39),
(18, 'sem molestie sodales. Mauris', 38970, 1564, 27),
(19, 'vel pede blandit congue.', 32329, 25784, 100),
(20, 'at, velit. Cras lorem', 79466, 63553, 39),
(21, 'malesuada fames ac turpis', 67248, 73380, 42),
(22, 'tellus lorem eu metus.', 45079, 71895, 32),
(23, 'Donec feugiat metus sit', 58312, 51388, 20),
(24, 'Mauris non dui nec', 28943, 21823, 69),
(25, 'Quisque nonummy ipsum non', 19236, 89396, 12),
(26, 'nascetur ridiculus mus. Proin', 93157, 32983, 5),
(27, 'parturient montes, nascetur ridiculus', 84237, 79220, 48),
(28, 'tempus eu, ligula. Aenean', 98928, 36861, 43),
(29, 'placerat. Cras dictum ultricies', 7507, 1913, 48),
(30, 'vulputate, nisi sem semper', 42129, 12619, 7),
(31, 'ac libero nec ligula', 39227, 44443, 72),
(32, 'accumsan laoreet ipsum. Curabitur', 34567, 87396, 45),
(33, 'Maecenas ornare egestas ligula.', 8921, 74720, 3),
(34, 'dui lectus rutrum urna,', 87377, 63845, 93),
(35, 'enim non nisi. Aenean', 89676, 21395, 4),
(36, 'velit justo nec ante.', 13181, 67327, 71),
(37, 'consectetuer ipsum nunc id', 73099, 18334, 17),
(38, 'neque sed dictum eleifend,', 66257, 5134, 58),
(39, 'In condimentum. Donec at', 92235, 91253, 85),
(40, 'lobortis augue scelerisque mollis.', 25275, 13373, 25),
(41, 'in lobortis tellus justo', 66835, 5137, 89),
(42, 'bibendum fermentum metus. Aenean', 21460, 82871, 78),
(43, 'mollis vitae, posuere at,', 94921, 60069, 73),
(44, 'tincidunt. Donec vitae erat', 83357, 60461, 32),
(45, 'nulla vulputate dui, nec', 63363, 35769, 66),
(46, 'sapien, cursus in, hendrerit', 40750, 49824, 26),
(47, 'morbi tristique senectus et', 33698, 48457, 100),
(48, 'Cras eu tellus eu', 28836, 66897, 99),
(49, 'feugiat non, lobortis quis,', 37563, 15777, 52),
(50, 'Cum sociis natoque penatibus', 77953, 23490, 91),
(51, 'dictum augue malesuada malesuada.', 77515, 65148, 11),
(52, 'sed tortor. Integer aliquam', 66054, 86664, 69),
(53, 'non enim commodo hendrerit.', 76687, 30059, 31),
(54, 'ultrices sit amet, risus.', 30607, 30703, 40),
(55, 'justo sit amet nulla.', 16005, 44401, 81),
(56, 'Donec egestas. Aliquam nec', 47885, 99684, 90),
(57, 'arcu eu odio tristique', 4531, 58966, 62),
(58, 'rutrum lorem ac risus.', 59782, 21465, 4),
(59, 'orci lacus vestibulum lorem,', 95248, 77912, 30),
(60, 'urna. Ut tincidunt vehicula', 22547, 98954, 12),
(61, 'sapien. Nunc pulvinar arcu', 83951, 88160, 8),
(62, 'enim, sit amet ornare', 61381, 20230, 5),
(63, 'pede nec ante blandit', 42992, 14328, 46),
(64, 'lectus rutrum urna, nec', 66944, 76986, 5),
(65, 'amet metus. Aliquam erat', 75698, 55002, 73),
(66, 'dui, in sodales elit', 37586, 24099, 85),
(67, 'orci lacus vestibulum lorem,', 55778, 90745, 51),
(68, 'sit amet lorem semper', 45665, 96596, 1),
(69, 'dignissim. Maecenas ornare egestas', 7754, 2896, 7),
(70, 'Integer id magna et', 21823, 88385, 73),
(71, 'nec urna suscipit nonummy.', 34010, 93840, 15),
(72, 'mi lorem, vehicula et,', 23651, 97725, 59),
(73, 'mollis. Integer tincidunt aliquam', 87431, 88836, 65),
(74, 'pretium et, rutrum non,', 56388, 18977, 4),
(75, 'a felis ullamcorper viverra.', 50022, 54119, 99),
(76, 'et pede. Nunc sed', 33538, 77099, 65),
(77, 'lectus quis massa. Mauris', 96687, 37814, 56),
(78, 'Nam porttitor scelerisque neque.', 41444, 60974, 36),
(79, 'feugiat non, lobortis quis,', 44378, 87196, 46),
(80, 'pellentesque. Sed dictum. Proin', 29317, 39283, 82),
(81, 'vel pede blandit congue.', 82854, 12845, 41),
(82, 'sit amet risus. Donec', 18163, 33894, 28),
(83, 'lacus pede sagittis augue,', 31626, 11610, 1),
(84, 'lacus. Cras interdum. Nunc', 82310, 8563, 6),
(85, 'ut aliquam iaculis, lacus', 23279, 65200, 70),
(86, 'amet risus. Donec egestas.', 52497, 40600, 76),
(87, 'sed orci lobortis augue', 70851, 48830, 69),
(88, 'justo sit amet nulla.', 98229, 50378, 50),
(89, 'facilisis facilisis, magna tellus', 77086, 8160, 98),
(90, 'sit amet ultricies sem', 20362, 11659, 92),
(91, 'mauris ipsum porta elit,', 39616, 48456, 87),
(92, 'vulputate mauris sagittis placerat.', 95751, 70940, 16),
(93, 'arcu. Vivamus sit amet', 12908, 35489, 37),
(94, 'arcu. Vestibulum ut eros', 60585, 16478, 23),
(95, 'nulla magna, malesuada vel,', 97051, 72800, 6),
(96, 'amet nulla. Donec non', 13006, 67085, 11),
(97, 'Aliquam nisl. Nulla eu', 45262, 24082, 52),
(98, 'purus sapien, gravida non,', 85686, 94356, 35),
(99, 'cursus. Integer mollis. Integer', 22884, 25992, 68),
(100, 'ridiculus mus. Donec dignissim', 92499, 94572, 49);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `Depth_Four`
--
ALTER TABLE `Depth_Four`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_depth_three` (`depth_three_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `Depth_Four`
--
ALTER TABLE `Depth_Four`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `Depth_Four`
--
ALTER TABLE `Depth_Four`
  ADD CONSTRAINT `fk_depth_three` FOREIGN KEY (`depth_three_id`) REFERENCES `Depth_Three` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
