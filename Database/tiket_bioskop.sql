-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 01 Mar 2023 pada 03.20
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tiket_bioskop`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `log`
--

CREATE TABLE `log` (
  `id` int(11) NOT NULL,
  `id_users` int(11) NOT NULL,
  `activity` text NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `nama_film` varchar(45) NOT NULL,
  `genre` varchar(20) NOT NULL,
  `durasi` varchar(20) NOT NULL,
  `harga_tiket` varchar(100) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `products`
--

INSERT INTO `products` (`id`, `nama_film`, `genre`, `durasi`, `harga_tiket`, `created_at`, `updated_at`) VALUES
(2, 'Doraemon Standby Me', 'Comedy, Drama', '110', 'Rp.50.000', '2023-02-23 07:09:28', '2023-02-23 07:09:28'),
(4, 'It', 'Horor, Comedy', '90', 'Rp.40.000', '2023-02-24 04:19:19', '2023-02-24 04:19:19'),
(5, 'Hotel Transylvania', 'Comedy', '130', '45000', '2023-03-01 00:35:32', '2023-03-01 00:35:32');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transactions`
--

CREATE TABLE `transactions` (
  `id` int(11) NOT NULL,
  `id_products` int(11) NOT NULL,
  `nama_pelanggan` varchar(45) NOT NULL,
  `nomor_unik` varchar(10) NOT NULL,
  `uang_bayar` int(11) NOT NULL,
  `uang_kembali` int(11) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `jenkel` enum('L','P') NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `nophone` varchar(20) NOT NULL,
  `role` enum('admin','kasir','owner') NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `nama`, `jenkel`, `alamat`, `nophone`, `role`, `created_at`, `updated_at`) VALUES
(1, 'Mustika', 'mustika123', 'mustika', 'L', 'Jabong', '082140095431', 'admin', '2023-02-20 03:14:36', '2023-02-20 03:14:36'),
(2, 'Syukur', 'syukur123', 'syukur', 'L', 'Subang', '082140095478', 'kasir', '2023-02-20 15:40:40', '2023-02-20 15:40:40'),
(3, 'Hadi', 'hadi123', 'hadi', 'L', 'Subang', '082234546556', 'owner', '2023-02-20 15:40:40', '2023-02-20 15:40:40'),
(4, 'Riswan', 'riswan', 'Rizwan', 'L', 'Cadika', '086587789865', 'owner', '2023-02-22 02:24:24', '2023-02-22 02:24:24'),
(6, 'wili', 'wili123', 'Wili', 'L', 'ytta', '082130094567', 'owner', '2023-02-22 17:53:55', '2023-02-22 17:53:55'),
(7, 'Ranpo', 'ranpo123', 'Edogawa', 'L', 'Soebang', '082148856432', 'owner', '2023-02-23 01:17:47', '2023-02-23 01:17:47'),
(8, 'Adit', 'adit123', 'Aditia', 'L', 'Walahar', '082546758976', 'kasir', '2023-02-24 01:20:53', '2023-02-24 01:20:53');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `log`
--
ALTER TABLE `log`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_user` (`id_users`);

--
-- Indeks untuk tabel `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_products` (`id_products`);

--
-- Indeks untuk tabel `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `log`
--
ALTER TABLE `log`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT untuk tabel `transactions`
--
ALTER TABLE `transactions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `log`
--
ALTER TABLE `log`
  ADD CONSTRAINT `log_ibfk_1` FOREIGN KEY (`id_users`) REFERENCES `users` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ketidakleluasaan untuk tabel `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `transactions_ibfk_1` FOREIGN KEY (`id_products`) REFERENCES `products` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
