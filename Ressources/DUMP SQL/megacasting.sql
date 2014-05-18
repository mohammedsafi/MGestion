/*
Navicat MySQL Data Transfer

Source Server         : fashionparf
Source Server Version : 50612
Source Host           : localhost:3306
Source Database       : megacasting

Target Server Type    : MYSQL
Target Server Version : 50612
File Encoding         : 65001

Date: 2014-05-18 23:22:55
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `annonce`
-- ----------------------------
DROP TABLE IF EXISTS `annonce`;
CREATE TABLE `annonce` (
  `Annonce_Id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Clefs primaire de la table',
  `Annonce_Titre` varchar(100) NOT NULL COMMENT 'Titre de l''annonce sur le site',
  `Annonce_Duree_Diffusion` int(11) NOT NULL,
  `Annonce_Debut_Ctrat` date NOT NULL,
  `Annonce_Detail_Poste` varchar(1000) NOT NULL COMMENT 'Contenue de l''annonce affiché sur le site',
  `Annonce_Detail_Profil` varchar(1000) NOT NULL,
  `Annonce_Adresse` varchar(50) NOT NULL,
  `Annonce_Ville` varchar(20) NOT NULL,
  `Annonce_CP` varchar(20) NOT NULL,
  `Annonce_Mail` varchar(100) NOT NULL,
  `Annonce_Telephone` varchar(20) NOT NULL,
  `Annonce_Type_Contrat` int(11) NOT NULL,
  `Annonce_Metier_Cible` int(11) NOT NULL,
  `Annonce_Societe` int(11) NOT NULL COMMENT 'Societe qui a demandé de publier cette annonce',
  `Annonce_Ref` varchar(50) NOT NULL,
  PRIMARY KEY (`Annonce_Id`),
  KEY `Annonce_Societe` (`Annonce_Societe`),
  KEY `Annonce_Societe_2` (`Annonce_Societe`),
  KEY `Annonce_Societe_3` (`Annonce_Societe`),
  KEY `annonce_ibfk_2` (`Annonce_Metier_Cible`),
  KEY `annonce_ibfk_3` (`Annonce_Type_Contrat`),
  CONSTRAINT `annonce_ibfk_1` FOREIGN KEY (`Annonce_Societe`) REFERENCES `societe` (`Societe_Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `annonce_ibfk_2` FOREIGN KEY (`Annonce_Metier_Cible`) REFERENCES `metier` (`Metier_Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `annonce_ibfk_3` FOREIGN KEY (`Annonce_Type_Contrat`) REFERENCES `contrat` (`Contrat_Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of annonce
-- ----------------------------

-- ----------------------------
-- Table structure for `contrat`
-- ----------------------------
DROP TABLE IF EXISTS `contrat`;
CREATE TABLE `contrat` (
  `Contrat_Id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Identifiant du contrat',
  `Contrat_Libelle` varchar(100) NOT NULL COMMENT 'Contient le libelle du contrat',
  PRIMARY KEY (`Contrat_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of contrat
-- ----------------------------
INSERT INTO `contrat` VALUES ('1', 'CDD');
INSERT INTO `contrat` VALUES ('2', 'CDI');
INSERT INTO `contrat` VALUES ('3', 'Interim');

-- ----------------------------
-- Table structure for `domaine`
-- ----------------------------
DROP TABLE IF EXISTS `domaine`;
CREATE TABLE `domaine` (
  `Domaine_Id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'identifiant du domaine',
  `Domain_Libelle` varchar(100) NOT NULL COMMENT 'Contient le libelle du domaine',
  PRIMARY KEY (`Domaine_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of domaine
-- ----------------------------
INSERT INTO `domaine` VALUES ('1', 'Informatique');
INSERT INTO `domaine` VALUES ('2', 'Cuisine');
INSERT INTO `domaine` VALUES ('3', 'Bâtiment');
INSERT INTO `domaine` VALUES ('4', 'Musique');

-- ----------------------------
-- Table structure for `metier`
-- ----------------------------
DROP TABLE IF EXISTS `metier`;
CREATE TABLE `metier` (
  `Metier_Id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Clé primaire des métiers',
  `Metier_Libelle` varchar(100) NOT NULL COMMENT 'Contient le libelle du metier en question',
  `Metier_Domaine` int(11) NOT NULL COMMENT 'Contient la clé etrangère qui lie un metier à un domaine',
  PRIMARY KEY (`Metier_Id`),
  KEY `Metier_Domaine` (`Metier_Domaine`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of metier
-- ----------------------------
INSERT INTO `metier` VALUES ('1', 'Analyste Programmeur', '1');
INSERT INTO `metier` VALUES ('2', 'Chef de cuisine', '2');
INSERT INTO `metier` VALUES ('3', 'Charpentier', '3');

-- ----------------------------
-- Table structure for `offre`
-- ----------------------------
DROP TABLE IF EXISTS `offre`;
CREATE TABLE `offre` (
  `Offre_Id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Identifiant d''une offre',
  `Offre_Intitule` varchar(150) NOT NULL COMMENT 'Intitulé de l''offre',
  `Offre_Reference` varchar(150) NOT NULL COMMENT 'Reference de l''offre',
  `Offre_DateDePub` date NOT NULL COMMENT 'Date de publication de l''offre',
  `Offre_DureeDiffusion` time NOT NULL COMMENT 'Durée de la diffusion de l''offre',
  `Offre_DatDebContrat` date NOT NULL COMMENT 'Date du début du contrat de l''offre',
  `Offre_DescriptionPoste` varchar(500) NOT NULL COMMENT 'Description du poste proposé par l''offre',
  `Offre_DescriptionProfil` varchar(500) NOT NULL COMMENT 'Description du profil attendu par l''offre',
  `Offre_Adresse` varchar(100) NOT NULL COMMENT 'Adresse de l''offre',
  `Offre_Ville` varchar(30) NOT NULL COMMENT 'Ville ou l''offre est proposé',
  `Offre_CodePostal` int(11) NOT NULL COMMENT 'Code postale de la ville de l''offre',
  `Offre_Email` varchar(75) NOT NULL COMMENT 'Email pour joindre l''annonceur',
  `Offre_Telephone` varchar(10) NOT NULL COMMENT 'Telephone pour joindre l''annonceur',
  `Offre_Contrat` int(11) NOT NULL COMMENT 'Clé étrangère qui lie une offre à un contrat',
  `Offre_Metier` int(11) NOT NULL COMMENT 'Clé étrangère qui lie l''offre au métier',
  `Offre_Domaine` int(11) NOT NULL COMMENT 'Clé étrangère qui lie un domaine de métier à une offre',
  `Offre_Societe` int(11) NOT NULL COMMENT 'Lie la société à l''offre',
  PRIMARY KEY (`Offre_Id`),
  KEY `Offre_Societe` (`Offre_Societe`),
  KEY `Offre_Societe_2` (`Offre_Societe`),
  KEY `Offre_Societe_3` (`Offre_Societe`),
  KEY `Offre_Domaine` (`Offre_Domaine`),
  KEY `Offre_Metier` (`Offre_Metier`),
  KEY `Offre_Contrat` (`Offre_Contrat`),
  CONSTRAINT `offre_ibfk_1` FOREIGN KEY (`Offre_Contrat`) REFERENCES `contrat` (`Contrat_Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `offre_ibfk_2` FOREIGN KEY (`Offre_Metier`) REFERENCES `metier` (`Metier_Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `offre_ibfk_3` FOREIGN KEY (`Offre_Domaine`) REFERENCES `domaine` (`Domaine_Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `offre_ibfk_4` FOREIGN KEY (`Offre_Societe`) REFERENCES `societe` (`Societe_Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of offre
-- ----------------------------

-- ----------------------------
-- Table structure for `personne`
-- ----------------------------
DROP TABLE IF EXISTS `personne`;
CREATE TABLE `personne` (
  `Personne_Id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Identifiant de la personne',
  `Personne_Nom` varchar(75) NOT NULL COMMENT 'Contient le nom de la personne ',
  `Personne_Prenom` varchar(75) NOT NULL COMMENT 'Contient le nom de la personne',
  `Personne_DateNaiss` date NOT NULL COMMENT 'Date de naissance de la personne',
  `Personne_Mail` varchar(75) NOT NULL COMMENT 'Mail de la personne',
  `Personne_Fax` varchar(20) NOT NULL COMMENT 'Fax de la personne',
  `Personne_Adresse` varchar(125) NOT NULL COMMENT 'Adresse de la personne',
  `Personne_Metier` varchar(100) NOT NULL COMMENT 'Metier de la personne',
  `Personne_Telephone` varchar(10) NOT NULL COMMENT 'Telephone de la personne',
  `Personne_Password` varchar(50) NOT NULL COMMENT 'Telephone de la personne',
  `Personne_SiteWeb` varchar(100) NOT NULL COMMENT 'Site web de l''utilisateur',
  PRIMARY KEY (`Personne_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of personne
-- ----------------------------
INSERT INTO `personne` VALUES ('5', 'Merlin', 'Cédric', '1995-11-08', 'cmerlin', 'Fax', 'Adresse', 'Metier', 'Tel', 'Pass', 'Site');
INSERT INTO `personne` VALUES ('6', 'Joncheray', 'Maxence', '1995-11-08', 'mjoncheray', 'null', 'null', 'null', 'null', 'null', 'null');
INSERT INTO `personne` VALUES ('7', 'Ferandin', 'Peter', '1995-11-08', 'pferandin', 'null', 'null', 'null', 'null', 'null', 'null');
INSERT INTO `personne` VALUES ('9', 'Maigne', 'Benjamin', '1995-11-08', 'bmaigne', 'null', 'null', 'null', 'null', 'null', 'null');
INSERT INTO `personne` VALUES ('10', 'Bureau', 'Julien', '2014-04-30', 'jbureau', 'test22', 'test44', 'test55', 'test11', 'test33', 'test666');

-- ----------------------------
-- Table structure for `postuler`
-- ----------------------------
DROP TABLE IF EXISTS `postuler`;
CREATE TABLE `postuler` (
  `Postuler_Offre` int(11) NOT NULL COMMENT 'Clé étrangères vers l''offre ',
  `Postuler_Personne` int(11) NOT NULL COMMENT 'Clé étrangères vers la personne qui a postuler',
  PRIMARY KEY (`Postuler_Offre`,`Postuler_Personne`),
  KEY `Postuler_Offre` (`Postuler_Offre`,`Postuler_Personne`),
  KEY `Postuler_Personne` (`Postuler_Personne`),
  CONSTRAINT `postuler_ibfk_1` FOREIGN KEY (`Postuler_Offre`) REFERENCES `offre` (`Offre_Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `postuler_ibfk_2` FOREIGN KEY (`Postuler_Personne`) REFERENCES `personne` (`Personne_Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of postuler
-- ----------------------------

-- ----------------------------
-- Table structure for `societe`
-- ----------------------------
DROP TABLE IF EXISTS `societe`;
CREATE TABLE `societe` (
  `Societe_Id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Clé primaire de la table Soiciété',
  `Societe_Nom` varchar(75) NOT NULL COMMENT 'Nom de la societe',
  `Societe_RaisonSocial` varchar(50) NOT NULL COMMENT 'Contient la raison social de l''entreprise',
  `Societe_Adresse` varchar(100) NOT NULL COMMENT 'Contient l''adresse de l''entreprise',
  `Societe_Ville` varchar(35) NOT NULL COMMENT 'Contient la ville ou se situe l''entreprise',
  `Societe_Email` varchar(75) NOT NULL COMMENT 'Contient l''email de la societe',
  `Societe_Telephone` varchar(10) NOT NULL COMMENT 'Contient le numéro de telephone de la société ',
  `Societe_CodePostal` int(11) NOT NULL COMMENT 'Contient le code postale de la société ',
  `Societe_Type` varchar(35) NOT NULL COMMENT 'Contient le type de la société (Annonceur ou Diffuseur) ',
  PRIMARY KEY (`Societe_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of societe
-- ----------------------------
INSERT INTO `societe` VALUES ('1', 'testeur', 'test', 'test', 'test', 'test', 'test', '0', 'test');
INSERT INTO `societe` VALUES ('2', 'Progmania', 'SARL', '7 rue de sainte suzanne', 'Montsûrs', 'p.ferandin@iia-laval.fr', '0778546527', '53150', 'Informatique');
