CREATE DATABASE  IF NOT EXISTS `pruebademo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `pruebademo`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: pruebademo
-- ------------------------------------------------------
-- Server version	8.4.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Cliente` varchar(255) NOT NULL,
  `Telefono` varchar(255) DEFAULT NULL,
  `Correo` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=206 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,'Brian','4254888','brian@gmail.com'),(4,'rodolfito','5645454','asdasd@gmail.com'),(10,'agustina','1124571','agustina@gmail.com'),(11,'dsdasd','5446','dsfds'),(15,'loqui','4545','loqui@gmail.com'),(32,'carlitos','456565','sdas@gmail.com'),(53,'joni','64565','joni@gmail.com');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(255) NOT NULL,
  `Precio` float DEFAULT NULL,
  `Categoria` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'Papa Grande',50,'Verduras'),(2,'Papa chica',30,'Verduras'),(3,'Berenjena',350.2,'Verdura'),(4,'Papa Exportacion ',150,'Verduras'),(5,'Zanahoria Exportacion ',150,'Verduras'),(6,'papitaverde',50,'400'),(7,'paparoja',400,'verdura'),(15,'zanahoria roja',250,'verduras'),(56,'Papa Mini ',20,'verdura');
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `IDCliente` int NOT NULL,
  `Fecha` datetime DEFAULT NULL,
  `Total` float DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` VALUES (2,2,'1980-05-10 00:00:00',674),(3,3,'2022-09-10 00:00:00',651),(7,10,'2025-02-26 16:47:17',100050),(9,1,'2025-02-27 10:32:17',72500),(15,15,'2025-02-28 00:20:29',10000),(16,10,'2025-02-28 01:07:35',50),(17,4,'2025-02-28 02:22:39',350.2),(18,1,'2025-02-28 16:36:05',1751);
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventasitems`
--

DROP TABLE IF EXISTS `ventasitems`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventasitems` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `IDVenta` int NOT NULL,
  `IDProducto` int NOT NULL,
  `PrecioUnitario` float DEFAULT NULL,
  `Cantidad` float DEFAULT NULL,
  `PrecioTotal` float DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventasitems`
--

LOCK TABLES `ventasitems` WRITE;
/*!40000 ALTER TABLE `ventasitems` DISABLE KEYS */;
INSERT INTO `ventasitems` VALUES (6,7,5,200,500,100000),(7,7,3,5,10,50),(8,7,0,0,0,0),(11,9,1,500,10,5000),(12,9,56,1500,45,67500),(13,9,0,0,0,0),(19,12,1,100,100,10000),(20,12,0,0,0,0),(26,15,2,1000,10,10000),(27,15,0,0,0,0),(28,16,6,50,1,50),(29,16,0,0,0,0),(30,17,3,350.2,1,350.2),(31,17,0,0,0,0),(32,18,3,350.2,5,1751),(33,18,0,0,0,0);
/*!40000 ALTER TABLE `ventasitems` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-28 17:54:29
