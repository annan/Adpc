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
