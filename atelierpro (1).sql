-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 23 mai 2024 à 08:40
-- Version du serveur : 8.2.0
-- Version de PHP : 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `atelierpro`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` date NOT NULL,
  `datefin` date DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(4, '2024-06-25', '2024-06-27', 2),
(4, '2024-06-18', '2024-06-20', 0),
(4, '2024-06-05', '2024-06-07', 1),
(4, '2024-05-24', '2024-05-27', 4),
(0, '2024-05-23', '2024-05-25', 1),
(7, '2024-02-16', '2024-02-17', 2),
(2, '2023-05-11', '2023-05-12', 2),
(8, '2024-04-10', '2024-04-14', 2),
(8, '2023-09-19', '2023-09-22', 3),
(9, '2023-09-29', '2023-09-30', 3),
(9, '2024-03-17', '2024-03-19', 3),
(8, '2023-09-13', '2023-09-15', 3),
(5, '2024-04-17', '2024-04-19', 3),
(2, '2023-09-16', '2023-09-19', 2),
(2, '2023-12-04', '2023-12-08', 3),
(10, '2024-01-10', '2024-01-12', 2),
(2, '2023-10-30', '2023-10-31', 2),
(3, '2024-04-16', '2024-04-19', 3),
(7, '2024-04-29', '2024-04-30', 3),
(10, '2023-11-02', '2023-11-04', 2),
(9, '2023-11-27', '2023-11-28', 3),
(9, '2023-08-13', '2023-08-15', 3),
(2, '2023-06-13', '2023-06-18', 3),
(3, '2024-04-12', '2024-04-18', 2),
(4, '2023-07-28', '2023-07-29', 2),
(3, '2023-11-17', '2023-11-18', 2),
(7, '2024-03-12', '2024-03-18', 2),
(9, '2024-04-19', '2024-04-21', 2),
(4, '2024-03-20', '2024-03-24', 2),
(10, '2024-01-18', '2024-01-19', 1),
(7, '2023-10-12', '2023-10-15', 1),
(8, '2024-04-16', '2024-04-19', 1),
(4, '2024-03-07', '2024-03-08', 3),
(4, '2023-12-01', '2023-12-05', 1),
(4, '2023-05-03', '2023-05-05', 2),
(5, '2024-03-23', '2024-03-27', 1),
(6, '2024-01-17', '2024-01-18', 1),
(3, '2023-07-16', '2023-07-18', 3),
(8, '2023-08-22', '2023-08-25', 2),
(2, '2023-11-30', '2023-12-03', 2),
(6, '2023-07-13', '2023-07-15', 2),
(9, '2024-02-22', '2024-02-27', 2),
(5, '2023-10-30', '2023-10-31', 2),
(4, '2023-07-24', '2023-07-26', 2),
(8, '2023-11-05', '2023-11-09', 1),
(9, '2024-01-18', '2024-01-19', 3),
(6, '2024-04-29', '2024-04-30', 1),
(1, '2023-12-16', '2023-12-18', 3),
(5, '2023-07-21', '2023-07-23', 2),
(10, '2024-04-28', '2024-04-29', 1),
(7, '2023-08-03', '2023-08-06', 3),
(3, '2023-09-20', '2023-09-22', 2),
(7, '2023-08-02', '2023-08-05', 2),
(8, '2023-10-03', '2023-10-06', 3),
(4, '2024-07-03', '2024-07-06', 4),
(4, '2024-07-09', '2024-07-12', 2),
(4, '2024-08-12', '2024-08-16', 1),
(4, '2024-05-14', '2024-05-16', 1),
(4, '2024-09-10', '2024-09-11', 1),
(4, '2024-05-22', '2024-05-22', 1),
(4, '2024-10-02', '2024-10-04', 1),
(5, '2024-05-09', '2024-05-09', 3),
(5, '2024-05-29', '2024-05-31', 1);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Stanley', 'Dorian', '08 92 28 33 33', 'quisque.fringilla.euismod@yahoo.com', 3),
(2, 'Zamora', 'Evan', '05 25 08 86 17', 'dolor.fusce@yahoo.org', 2),
(3, 'Rush', 'Avram', '09 38 85 71 52', 'aliquam@aol.edu', 2),
(4, 'Britt', 'Walter', '05 08 41 77 44', 'neque.nullam@hotmail.net', 2),
(5, 'Espinoza', 'Sawyer', '09 81 03 74 65', 'etiam.vestibulum@yahoo.fr', 2),
(6, 'Lowe', 'Dahlia', '07 18 45 25 33', 'netus.et.malesuada@aol.ca', 3),
(7, 'Daugherty', 'Cruz', '08 82 83 22 26', 'consequat.lectus@google.ca', 3),
(8, 'Holder', 'Brandon', '08 38 53 12 35', 'eros.turpis@hotmail.com', 2),
(9, 'Schmidt', 'Octavia', '06 53 66 54 48', 'ut@hotmail.edu', 2),
(10, 'Raymond', 'Hilel', '06 53 34 78 32', 'duis@protonmail.net', 3),
(24, 'aba', 'fdtze', 'zèfe', 'zèef', 0);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb3_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8mb3_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('respjunior', 'd529385b7154ee065d11a2afda8b7bb6356afbc4640891a6bdf774f231b7f0e8');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
