-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Vært: mysql50.unoeuro.com
-- Genereringstid: 05. 12 2019 kl. 11:59:01
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
-- Struktur-dump for tabellen `Depth_Nine`
--

CREATE TABLE `Depth_Nine` (
  `id` int(6) UNSIGNED NOT NULL,
  `string_value` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `int_value` int(50) NOT NULL,
  `double_value` double NOT NULL,
  `depth_eight_id` int(6) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Data dump for tabellen `Depth_Nine`
--

INSERT INTO `Depth_Nine` (`id`, `string_value`, `int_value`, `double_value`, `depth_eight_id`) VALUES
(1, 'neque sed dictum eleifend,', 47435, 28420, 91),
(2, 'Mauris ut quam vel', 41552, 32311, 67),
(3, 'Donec luctus aliquet odio.', 52534, 5141, 21),
(4, 'Aenean massa. Integer vitae', 46727, 34909, 100),
(5, 'orci. Ut sagittis lobortis', 93130, 69824, 19),
(6, 'sit amet, consectetuer adipiscing', 60656, 8500, 54),
(7, 'varius ultrices, mauris ipsum', 84540, 70412, 29),
(8, 'nascetur ridiculus mus. Donec', 22221, 55681, 23),
(9, 'Morbi vehicula. Pellentesque tincidunt', 89785, 38279, 17),
(10, 'cursus non, egestas a,', 82572, 69933, 5),
(11, 'eu metus. In lorem.', 62479, 72879, 40),
(12, 'eu tellus eu augue', 51834, 76442, 2),
(13, 'et, rutrum eu, ultrices', 87491, 54500, 8),
(14, 'nec ante. Maecenas mi', 46890, 75134, 22),
(15, 'dolor vitae dolor. Donec', 11264, 52347, 7),
(16, 'Suspendisse sed dolor. Fusce', 58007, 54081, 68),
(17, 'lorem. Donec elementum, lorem', 96672, 3924, 40),
(18, 'at, velit. Cras lorem', 9735, 36800, 60),
(19, 'Etiam gravida molestie arcu.', 98914, 10314, 34),
(20, 'lorem, sit amet ultricies', 79852, 8006, 4),
(21, 'eget massa. Suspendisse eleifend.', 92580, 91829, 48),
(22, 'tortor nibh sit amet', 10227, 8119, 48),
(23, 'turpis vitae purus gravida', 56524, 98221, 79),
(24, 'diam nunc, ullamcorper eu,', 60597, 91088, 44),
(25, 'id sapien. Cras dolor', 11636, 10767, 90),
(26, 'eget metus eu erat', 26714, 17451, 16),
(27, 'eu eros. Nam consequat', 80979, 13471, 85),
(28, 'eu dui. Cum sociis', 30576, 53262, 5),
(29, 'orci tincidunt adipiscing. Mauris', 63205, 67792, 25),
(30, 'a mi fringilla mi', 52046, 60796, 52),
(31, 'consectetuer rhoncus. Nullam velit', 97561, 26020, 27),
(32, 'Suspendisse aliquet, sem ut', 56304, 22473, 67),
(33, 'nibh enim, gravida sit', 18641, 32151, 40),
(34, 'elit, pharetra ut, pharetra', 13547, 37879, 99),
(35, 'Vivamus molestie dapibus ligula.', 71898, 77067, 35),
(36, 'augue. Sed molestie. Sed', 80313, 93952, 47),
(37, 'eu metus. In lorem.', 18791, 81971, 1),
(38, 'Pellentesque ultricies dignissim lacus.', 67938, 10722, 1),
(39, 'montes, nascetur ridiculus mus.', 96603, 23098, 63),
(40, 'lobortis mauris. Suspendisse aliquet', 80303, 4923, 39),
(41, 'eget laoreet posuere, enim', 97542, 45898, 63),
(42, 'per inceptos hymenaeos. Mauris', 8150, 43714, 66),
(43, 'Vestibulum accumsan neque et', 44433, 3463, 74),
(44, 'ante lectus convallis est,', 45363, 81864, 66),
(45, 'Integer aliquam adipiscing lacus.', 4087, 22494, 57),
(46, 'et risus. Quisque libero', 11797, 58934, 15),
(47, 'ipsum. Phasellus vitae mauris', 78350, 53889, 8),
(48, 'sapien imperdiet ornare. In', 96128, 59594, 32),
(49, 'enim consequat purus. Maecenas', 62253, 64430, 89),
(50, 'egestas hendrerit neque. In', 73322, 12451, 70),
(51, 'accumsan sed, facilisis vitae,', 33171, 28454, 89),
(52, 'vitae aliquam eros turpis', 27046, 60829, 75),
(53, 'posuere vulputate, lacus. Cras', 53177, 36126, 10),
(54, 'elementum, lorem ut aliquam', 59788, 30068, 39),
(55, 'et ipsum cursus vestibulum.', 42867, 54603, 98),
(56, 'tellus sem mollis dui,', 74998, 67522, 80),
(57, 'ullamcorper, velit in aliquet', 71742, 27765, 9),
(58, 'malesuada. Integer id magna', 52726, 76107, 22),
(59, 'Donec egestas. Duis ac', 57111, 67081, 96),
(60, 'eu odio tristique pharetra.', 51753, 30258, 90),
(61, 'eros. Proin ultrices. Duis', 20189, 11290, 40),
(62, 'porttitor scelerisque neque. Nullam', 83782, 84315, 13),
(63, 'Curae; Phasellus ornare. Fusce', 5610, 82489, 96),
(64, 'posuere cubilia Curae; Phasellus', 37180, 87233, 39),
(65, 'Nulla interdum. Curabitur dictum.', 12597, 40801, 65),
(66, 'sem, consequat nec, mollis', 34342, 65369, 96),
(67, 'ut, pharetra sed, hendrerit', 90093, 26710, 79),
(68, 'dis parturient montes, nascetur', 81184, 38146, 22),
(69, 'Pellentesque tincidunt tempus risus.', 91714, 91582, 32),
(70, 'pellentesque. Sed dictum. Proin', 15203, 57311, 59),
(71, 'lectus. Nullam suscipit, est', 67369, 67704, 35),
(72, 'Suspendisse eleifend. Cras sed', 68741, 66531, 3),
(73, 'odio vel est tempor', 60987, 23984, 29),
(74, 'Nunc sed orci lobortis', 67412, 2762, 86),
(75, 'ac nulla. In tincidunt', 21156, 27919, 66),
(76, 'dui quis accumsan convallis,', 22680, 15227, 5),
(77, 'ac risus. Morbi metus.', 57390, 93263, 70),
(78, 'amet, dapibus id, blandit', 45832, 10188, 62),
(79, 'velit eget laoreet posuere,', 13125, 5626, 68),
(80, 'semper, dui lectus rutrum', 24759, 75642, 81),
(81, 'pede, ultrices a, auctor', 81649, 53222, 98),
(82, 'ultricies dignissim lacus. Aliquam', 50802, 60821, 67),
(83, 'et nunc. Quisque ornare', 80600, 94763, 46),
(84, 'id risus quis diam', 60350, 80591, 85),
(85, 'justo. Praesent luctus. Curabitur', 98646, 83902, 1),
(86, 'sociis natoque penatibus et', 1968, 16183, 36),
(87, 'nec urna suscipit nonummy.', 69170, 3518, 73),
(88, 'dui, nec tempus mauris', 74930, 78536, 91),
(89, 'Sed eu eros. Nam', 2269, 98681, 24),
(90, 'luctus ut, pellentesque eget,', 55066, 66640, 36),
(91, 'nisi. Mauris nulla. Integer', 67588, 22659, 5),
(92, 'dui lectus rutrum urna,', 75614, 63956, 71),
(93, 'enim non nisi. Aenean', 29579, 37294, 51),
(94, 'id ante dictum cursus.', 14017, 53510, 15),
(95, 'lacinia at, iaculis quis,', 66909, 17817, 47),
(96, 'ornare lectus justo eu', 61787, 84527, 75),
(97, 'magna. Phasellus dolor elit,', 25272, 38013, 88),
(98, 'dui augue eu tellus.', 71693, 54557, 100),
(99, 'Curabitur vel lectus. Cum', 9370, 63685, 20),
(100, 'in faucibus orci luctus', 44664, 68306, 78);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `Depth_Nine`
--
ALTER TABLE `Depth_Nine`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_depth_eight` (`depth_eight_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `Depth_Nine`
--
ALTER TABLE `Depth_Nine`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `Depth_Nine`
--
ALTER TABLE `Depth_Nine`
  ADD CONSTRAINT `fk_depth_eight` FOREIGN KEY (`depth_eight_id`) REFERENCES `Depth_Eight` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
