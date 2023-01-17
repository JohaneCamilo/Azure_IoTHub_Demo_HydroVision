CREATE TABLE DeviceMessages
(
    Id bigint not null identity(1,1) primary key,
    DeviceId varchar(50) not null,
    TimeSent int not null,
    Temperature float not null,
    Humidity float not null,
)

DROP TABLE DeviceMessages;