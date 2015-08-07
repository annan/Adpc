Create Database `adpc`;

use `adpc`;

CREATE TABLE `airlines`(
  `airline_id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `airline_name` varchar(50) DEFAULT NULL,
  `created_date` datetime DEFAULT cur_date(),
  `airline_code` char(50) DEFAULT NULL,
  `active` tinyint(1),
  PRIMARY KEY `airline_id_key` (`airline_id`) ,
  UNIQUE KEY `airline_id_code` (`airline_code`),
  );
  .
  

  /* [PAK] 07 August 2015 21:13 */
CREATE TABLE `Countries`(
  `country_id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `country_name` varchar(50) DEFAULT NULL,
  `country_code` char(50) DEFAULT NULL,
  `active` tinyint(1) DEFAULT 1,
  `created_date` datetime DEFAULT  CURDATE(),
  PRIMARY KEY `country_id_key` (`country_id`) ,
  UNIQUE KEY `country_id_code` (`country_code`),
  );

  /* [PAK] 07 August 2015 21:13*/
CREATE TABLE `airport_cities`(
  `city_id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `country_id` int(5) unsigned NOT NULL,
  `city_name` varchar(50) DEFAULT NULL,
  `city_code` char(50) DEFAULT NULL,
  `active` tinyint(1) DEFAULT 1,
  `created_date` datetime DEFAULT  CURDATE(),
  PRIMARY KEY `city_id_key` (`city_id`) ,
  UNIQUE KEY `city_id_code` (`city_code`),
  CONSTRAINT `airport_cities_country_idfk` FOREIGN KEY (`country_id`) REFERENCES `Countries` (`id`)
  );