create database LogisticMan; 

create table Users(
full_name varchar(20) not null,
username varchar(20) primary key not null,
password varchar(20) not null,
phone varchar(20) not null,
dob date not null,
);

create table RequestShipment(
request_id int primary key not null ,
username varchar(20) not null,
fromCountry varchar(20) not null,
fromCity varchar(20) not null,
toCountry varchar(20) not null,
toCity varchar(20) not null,
phoneNum varchar(20) not null,
Delivery_Date date not null,
Request_detail varchar(180) not null,
);

create table AcceptedOrders(
orderId int primary key not null,
username varchar(20) not null,
fromCountry varchar(20) not null,
fromCity varchar(20) not null,
toCountry varchar(20) not null,
toCity varchar(20) not null,
phoneNum varchar(20) not null,
Delivery_Date date not null,
Request_detail varchar(180) not null,
);
create table CanceledOrders (
orderId int primary key not null,
username varchar(20) not null,
fromCountry varchar(20) not null,
fromCity varchar(20) not null,
toCountry varchar(20) not null,
toCity varchar(20) not null,
phoneNum varchar(20) not null,
Delivery_Date date not null,
Request_detail varchar(180) not null,
);


create table BookingManager(
full_name varchar(20) not null,
username varchar(20) primary key not null,

password varchar(20) not null,
phoneNum varchar(20) not null,

);

create table SupAdmin(
full_name varchar(20) not null,
username varchar(20) primary key not null,

password varchar(20) not null,
phoneNum varchar(20) not null,

);


drop table SupAdmin;










