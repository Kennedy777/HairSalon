# EpiCutUs Salon Proto-CRM

#### Epicodus Week 3 & 4 C# Independent Projecct 

#### by Marguerite Kennedy

## Description

This is an MVC web application for a fictioanl hair salon. The "owner" will be able to add a list of the stylists, and for each stylist, add clients who see that stylist. The stylists work independently, so each client only belongs to a single stylist. The stylists also have specialties, and more than one stylist can have a given specialty. The user can see a list of stylists, specialties, and clients.

## Specifications

The user, a hypothetical owner/administrator of a salon, will be able to:
* select a stylist, see their details, and see a list of all clients that belong to that stylist.
* add new stylists to the system when hired.
* add new clients to a specific stylist. 
* In this salon, a client cannot be added without a stylist, and a client can't belong to more than one stylist, creating a "one to many" relationship. 
* Stylists can have multiple specialties, and vice versa. 

## Requirements
* #### MySQL Server using [MAMP](https://www.mamp.info/en/) or [MySQL Community](https://dev.mysql.com/downloads/mysql/)
* #### .NET Framework

### Setup Instructions
Download and install .NET Core, .NET Core Runtime, and MAMP 

* Clone repository & open in your preferred text editor
* Open MAMP (Apache port 8888 & MySql port 8889) and launch Apache & MySql servers 
* Use the following SQL commands in MySql to create database:
* > "CREATE DATABASE hair_salon;"
* > "USE hair_salon;"
* > "CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255));"
* > "CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255)), stylist_id INT;"
* > CREATE TABLE speciality (id serial PRIMARY KEY, name VARCHAR(255));
* > CREATE TABLE speciality_stylists (id serial PRIMARY KEY, speciality_id INT, stylist_id INT;
* > "CREATE DATABASE hair_salon_test;"
* > "USE hair_salon_test;"
* > "CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255));"
* > "CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255)), stylist_id INT;"
* > CREATE TABLE speciality (id serial PRIMARY KEY, name VARCHAR(255));
* > CREATE TABLE speciality_stylists (id serial PRIMARY KEY, speciality_id INT, stylist_id INT;
* Navigate to "HairSalon" directory
* Use the following commands:
* > "dotnet restore"
* > "dotnet build"
* > "dotnet run"
* > Navigate to "http://localhost:5000" in your browser
* > Get a haircut, hippie! 

## Known Bugs
* None currently known. 

## Technologies Used 
  * C# 
  * MySql
  * Bootstrap
  * MAMP
  * .NET framework
  * MSTest

## Support and contact details

_Email me at reach.marguerite@gmail.com with any questions, comments, or concerns._

### License

*This software is licensed under the MIT license*

Copyright (c) 2019 Marguerite Kennedy
