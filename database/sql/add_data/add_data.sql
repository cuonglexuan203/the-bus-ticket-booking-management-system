insert into PLACE values
('1', N'An Giang'),
('2', N'Bà Rịa-Vũng Tàu'),
('3', N'Bạc Liêu'),
('4', N'Bắc Kạn'),
('5', N'Bắc Giang'),
('6', N'Bắc Ninh'),
('7', N'Bến Tre'),
('8', N'Bình Dương'),
('9', N'Bình Định'),
('10', N'Bình Phước'),
('11', N'Bình Thuận'),
('12', N'Cà Mau'),
('13', N'Cao Bằng'),
('14', N'Cần Thơ'),
('15', N'Đà Nẵng'),
('16', N'Đắk Lắk'),
('17', N'Đắk Nông'),
('18', N'Điện Biên'),
('19', N'Đồng Nai'),
('20', N'Đồng Tháp'),
('21', N'Gia Lai'),
('22', N'Hà Giang'),
('23', N'Hà Nam'),
('24', N'Hà Nội '),
('25', N'Hà Tây'),
('26', N'Hà Tĩnh'),
('27', N'Hải Dương'),
('28', N'Hải Phòng'),
('29', N'Hòa Bình'),
('30', N'Hồ Chí Minh'),
('31', N'Hậu Giang'),
('32', N'Hưng Yên'),
('33', N'Khánh Hòa'),
('34', N'Kiên Giang'),
('35', N'Kon Tum'),
('36', N'Lai Châu'),
('37', N'Lào Cai'),
('38', N'Lạng Sơn'),
('39', N'Lâm Đồng'),
('40', N'Long An'),
('41', N'Nam Định'),
('42', N'Nghệ An'),
('43', N'Ninh Bình'),
('44', N'Ninh Thuận'),
('45', N'Phú Thọ'),
('46', N'Phú Yên'),
('47', N'Quảng Bình'),
('48', N'Quảng Nam'),
('49', N'Quảng Ngãi'),
('50', N'Quảng Ninh'),
('51', N'Quảng Trị'),
('52', N'Sóc Trăng'),
('53', N'Sơn La'),
('54', N'Tây Ninh'),
('55', N'Thái Bình'),
('56', N'Thái Nguyên'),
('57', N'Thanh Hóa'),
('58', N'Thừa Thiên – Huế'),
('59', N'Tiền Giang'),
('60', N'Trà Vinh'),
('61', N'Tuyên Quang'),
('62', N'Vĩnh Long'),
('63', N'Vĩnh Phúc'),
('64', N'Yên Bái');

go
--
insert into BUS(registration_number, model, capacity, type) values ('78-FN10532', 'Suzuki', 30, 0)
insert into BUS(registration_number, model, capacity, type) values ('78-FN15642', 'Suzuki', 30, 0)
insert into BUS(registration_number, model, capacity , type) values ('78-FN17253', 'Suzuki', 16, 1)
insert into BUS(registration_number, model, capacity, type) values ('29A-102.43', 'Toyota', 27, 0)
insert into BUS(registration_number, model, capacity, type) values ('51G-987.65', 'Honda', 34, 0)
insert into BUS(registration_number, model, capacity, type) values ('34M-115.78', 'Mercedes-Benz', 20, 1)
insert into BUS(registration_number, model, capacity, type) values ('72F-963.24', 'BMW', 40, 0)
insert into BUS(registration_number, model, capacity, type) values ('43N-789.01', 'Audi', 31, 1)
insert into BUS(registration_number, model, capacity, type) values ('58B-456.32', 'Hyundai', 26, 1)
insert into BUS(registration_number, model, capacity, type) values ('14P-678.90', 'Kia', 33, 1)

--
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (16, N'172 Lê Duẩn, TP Buôn Ma Thuột, Đắk Lắk', '0262 393 6868',50,23)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (17, N'226 Hai Bà Trưng, Nghĩa Thành, Gia Nghĩa, Đắk Nông', '02613 67 67 67',87,11)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (3, N'QL1A, Khóm 2, P.7, TP.Bạc Liêu, Bạc Liêu', '02913 93 2345', 66,41)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (7, N'Đường Võ Nguyên Giáp, Quốc lộ 60, xã Sơn Đông, Tp. Bến Tre, Tỉnh Bến Tre', '02753646464', 77,32)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (12, N'309 Lý Thường Kiệt, P.6, TP.Cà Mau, Cà Mau', '02903 651 651',91,36)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (30, N'292 Đinh Bộ Lĩnh, phường 26, Bình Thạnh, Thành phố Hồ Chí Minh', '0283 511 9808',44,39)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (39, N'695-697, QL20 Liên Nghĩa, H.Đức Trọng, Lâm Đồng', '02633 651 651',85,10)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (39, N'735 Hùng Vương, TT.Di Linh, H.Di Linh, Lâm Đồng', '02633 788 799',71,54)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (39, N'280 Trần Phú, TX.Bảo Lộc, Lâm Đồng', '02633 731 731',98,47)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (34, N'QL80, KP 5, P.Bình San, TX.Hà Tiên, Kiên Giang (BX Hà Tiên)', '02973 66 88 66',66,11)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (34, N'397 QL 80, KP Ngã ba, TT.Kiên Lương, H.Kiên Lương, Kiên Giang', '02973 769 768',45,33)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (34, N'QL 80, Tổ 3, KP Kiên Tân, TT.Kiên Lương, H.Kiên Lương, Kiên Giang', '02973 699 688',33,30)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (31, N'BX Ngã 7, P.Ngã Bảy, TX.Ngã Bảy, Hậu Giang', '02933 868 866',41,29)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (20, N'Ngã 4 Võ Văn Kiệt - Điện Biên Phủ, P.Thanh An, TX.Hồng Ngự, Đồng Tháp', '02773 898 777',65,22)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (39, N'795 - QL20 - TT Liên Nghĩa - Huyện Đức Trọng - Lâm Đồng', '19006070',79,50)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (01, N'QL91, X.Bình Hòa, H.Châu Thành, An Giang', '02963 667 599',81,61)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (01, N'99 Hàm Nghi, P. Bình Khánh, TP.Long Xuyên, An Giang', '02963 98 9999',40,27)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (01, N'Bến Phà Vàm Cống,  TP.Long Xuyên, An Giang', '02963 930 967',7,5)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (01, N'Ngã 3 Lộ Tẻ Tri Tôn, X.Bình Hòa, H.Châu Thành, An Giang', '02963 66 76 56',22,9)
Insert into BUSSTATION(id_place, address, phone, bus_capacity, count_current_bus) values (01, N'Âp Phú Hữu, TT.Phú Hòa, H.Thoại Sơn, An Giang', '02963 878 111',96,83)

--
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values (N'Nguyễn Văn A', '0987654321', N'12 Đường Lê Lợi, Phường Bến Thành, Quận 1, TP. Hồ Chí Minh', '01234567890', 0, 'nguyenvana@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Trần Thị B', '0912345678', N'25 Ngõ 10 Đường Nguyễn Xiển, Phường Hạ Đình, Quận Thanh Xuân, Hà Nội', '09876543210', 1, 'trungnhan@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Lê Đức C', '0976543210', N'83 Đường Hùng Vương, Phường Lê Hồng Phong, Thành phố Đà Nẵng', '01234567891', 0, 'honglinh@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Phạm Minh D', '0901234567', N'121 Nguyễn Hữu Cảnh, Phường 22, Quận Bình Thạnh, TP. Hồ Chí Minh', '09090909090', 1, 'phamhoang@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Ngô Thanh E', '0965432109', N'56 Đường Lê Trọng Tấn, Phường La Khê, Quận Hà Đông, Hà Nội', '01111111111', 0, 'thaingo@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Đinh Hoàng F', '0943210765', N'2 Đường Nguyễn Công Trứ, Phường Nguyễn Thái Bình, Quận 1, TP. Hồ Chí Minh', '09999999999', 1, 'truongvuong@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Vũ Thị G', '0934560123', N'34 Đường Lê Lai, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh', '01234567892', 0, 'duongnguyen@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Hoàng Văn H', '0923456789', N'76 Đường Phạm Văn Đồng, Phường Mai Dịch, Quận Cầu Giấy, Hà Nội', '07777777777', 1, 'phuonganh@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Nguyễn Thị I', '0918765432', N'18 Đường Nguyễn Văn Linh, Phường Hòa Cường Bắc, Quận Hải Châu, Thành phố Đà Nẵng', '06666666666', 0, 'tranthang@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Trần Văn J', '0890123456', N'67 Đường Lê Duẩn, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh', '05555555555', 1, 'thuytrang@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Lê Thị K', '0887654321', N'9 Đường Nguyễn Thị Định, Phường Trung Hòa, Quận Cầu Giấy, Hà Nội', '04444444444', 0, 'minhtrang@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Bùi Minh L', '0865432198', N'43 Đường Bùi Thị Xuân, Phường Phạm Ngũ Lão, Quận 1, TP. Hồ Chí Minh', '03333333333', 1, 'thanhthao@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Phan Đình M', '0854321097', N'28 Đường Nguyễn Trãi, Phường Thanh Xuân Trung, Quận Thanh Xuân, Hà Nội', '02222222222', 0, 'quynhanh@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Trần Minh N', '0843210987', N'35 Đường Hùng Vương, Phường Xuân Phú, Quận Tân Phú, TP. Hồ Chí Minh', '01111111110', 1, 'vananh@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Nguyễn Thị O', '0832109876', N'15 Đường Lương Ngọc Quyến, Phường Hoàng Văn Thụ, Thành phố Hà Tĩnh, Tỉnh Hà Tĩnh', '09999999998', 0, 'vietanh@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Lê Thị P', '0821098765', N'72 Đường Trần Đại Nghĩa, Phường Đại Kim, Quận Hoàng Mai, Hà Nội', '01234567893', 1, 'thiennhat@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Võ Văn Q', '0810987654', N'49 Đường Trần Hưng Đạo, Phường Vĩnh Nguyên, Thành phố Nha Trang, Tỉnh Khánh Hòa', '01234567894', 0, 'linhchi@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Trần Văn R', '0798765432', N'3 Đường Nguyễn Văn Linh, Phường An Khánh, Quận Ninh Kiều, Thành phố Cần Thơ', '01234567895', 1, 'huyhoang@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Nguyễn Thị S', '0787654321', N'92 Đường Tôn Đức Thắng, Phường Hàng Bài, Quận Hoàn Kiếm, Hà Nội', '01234567896', 0, 'thuyduong@gmail.com')
Insert into PASSENGER(name, phone_number,address, identity_number,gender, email) values(N'Lê Văn T', '0776543210', N'61 Đường Hùng Vương, Phường Thắng Lợi, TP. Buôn Ma Thuột', '01234567897', 1, 'quanghuy@gmail.com')

--
insert into BUSROUTE(id_start_station, id_end_station, distance) values ('bs_0000000006', 'bs_0000000007', 305)
insert into BUSROUTE(id_start_station, id_end_station, distance) values ('bs_0000000007', 'bs_0000000006', 310)
insert into BUSROUTE(id_start_station, id_end_station, distance) values ('bs_0000000016', 'bs_0000000006', 240)
insert into BUSROUTE(id_start_station, id_end_station, distance) values ('bs_0000000001', 'bs_0000000007', 349)
insert into BUSROUTE(id_start_station, id_end_station, distance) values ('bs_0000000007', 'bs_0000000002', 242)
insert into BUSROUTE(id_start_station, id_end_station, distance) values ('bs_0000000003', 'bs_0000000007', 240)
insert into BUSROUTE(id_start_station, id_end_station, distance) values ('bs_0000000007', 'bs_0000000004', 87.6)
insert into BUSROUTE(id_start_station, id_end_station, distance) values ('bs_0000000011', 'bs_0000000007', 236)
insert into BUSROUTE(id_start_station, id_end_station, distance) values ('bs_0000000009', 'bs_0000000007', 202)
insert into BUSROUTE(id_start_station, id_end_station, distance) values ('bs_0000000007', 'bs_0000000019', 215)

--
insert into TRIP(id_bus, id_bus_route, departure_time,duration,booked_seat,status) values ('bus_0000000001', 'br_0000000001', '2023-04-20 15:30:00', 5, 11, 'waiting')
insert into TRIP(id_bus, id_bus_route, departure_time,duration,booked_seat,status) values ('bus_0000000002', 'br_0000000002', '2023-04-20 16:45:30', 7, 13, 'waiting')
insert into TRIP(id_bus, id_bus_route, departure_time,duration,booked_seat,status) values ('bus_0000000003', 'br_0000000003', '2023-04-21 09:12:00', 3, 15, 'going')
insert into TRIP(id_bus, id_bus_route, departure_time,duration,booked_seat,status) values ('bus_0000000004', 'br_0000000004', '2023-04-21 15:30:00', 4, 14, 'finish')
insert into TRIP(id_bus, id_bus_route, departure_time,duration,booked_seat,status) values ('bus_0000000005', 'br_0000000005', '2023-04-22 12:30:45', 5, 17, 'cancel')
insert into TRIP(id_bus, id_bus_route, departure_time,duration,booked_seat,status) values ('bus_0000000006', 'br_0000000006', '2023-04-23 08:00:00', 8, 18, 'waiting')
insert into TRIP(id_bus, id_bus_route, departure_time,duration,booked_seat,status) values ('bus_0000000007', 'br_0000000007', '2023-04-23 15:30:00', 7, 20, 'going')
insert into TRIP(id_bus, id_bus_route, departure_time,duration,booked_seat,status) values ('bus_0000000008', 'br_0000000008', '2023-04-24 17:30:15', 6, 16, 'going')
insert into TRIP(id_bus, id_bus_route, departure_time,duration,booked_seat,status) values ('bus_0000000009', 'br_0000000009', '2023-04-25 14:20:00', 10, 20, 'finish')
insert into TRIP(id_bus, id_bus_route, departure_time,duration,booked_seat,status) values ('bus_0000000010', 'br_0000000010', '2023-04-26 10:10:30', 15, 10, 'cancel')

--
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 1, 316000, 1, 'A15')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 1, 476000, 1, 'B10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 1, 309000, 1, 'A1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 1, 309000, 1, 'A2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 1, 309000, 1, 'A3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 1, 309000, 1, 'A4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 1, 309000, 1, 'A5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 1, 309000, 1, 'A6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 1, 309000, 1, 'A7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 1, 309000, 1, 'B1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 1, 309000, 1, 'B2')

INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 380000, 1, 'A8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 360000, 1, 'A9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'A10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'A11')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'A12')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'A13')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'A14')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'B3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'B4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'B5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'B6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'B7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'B8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'B9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 481000, 1, 'B11')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 200000, 0, 'N1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 200000, 0, 'N2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 200000, 0, 'N3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000001', 0, 200000, 0, 'N4')


INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 250000, 0, 'N1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 200000, 0, 'N2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 200000, 0, 'N5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 200000, 0, 'N7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 200000, 0, 'N10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 416000, 1, 'A1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 416000, 1, 'A2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 416000, 1, 'A7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 416000, 1, 'A9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 416000, 1, 'A11')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 500000, 1, 'B1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 500000, 1, 'B6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 500000, 1, 'B8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 1, 500000, 1, 'B10')

INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 200000, 0, 'N3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 200000, 0, 'N4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 200000, 0, 'N6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 200000, 0, 'N8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 200000, 0, 'N9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 321000, 0, 'A3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 321000, 0, 'A4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 321000, 0, 'A5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 321000, 0, 'A6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 321000, 0, 'A8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 420000, 0, 'B2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 420000, 0, 'B3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 420000, 0, 'B4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 420000, 0, 'B5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 420000, 0, 'B7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000002', 0, 420000, 0, 'B9')


INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 400000, 1, 'A1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 441000, 1, 'A2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 335000, 1, 'A3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 400000, 1, 'A4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 441000, 1, 'A5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 335000, 1, 'B1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 400000, 1, 'B2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 441000, 1, 'B3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 335000, 1, 'B4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 336000, 1, 'B5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 489000, 1, 'B6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 336000, 0, 'N1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 489000, 0, 'N2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 336000, 0, 'N3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 1, 489000, 0, 'N4')

INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000003', 0, 300000, 0, 'N5')


INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 434000, 0, 'N1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 434000, 0, 'N2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 434000, 0, 'N5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 407000, 1, 'A2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 407000, 1, 'A4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 407000, 1, 'A6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 407000, 1, 'A8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 407000, 1, 'A9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 407000, 1, 'B1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 407000, 1, 'B2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 407000, 1, 'B7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 407000, 1, 'B8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 407000, 1, 'B9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 1, 407000, 1, 'B10')

INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 426000, 0, 'N3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 426000, 0, 'N4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 426000, 0, 'N6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 426000, 0, 'N7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 416000, 1, 'A1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 367000, 1, 'A1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 416000, 1, 'A3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 367000, 1, 'A5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 416000, 1, 'A7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 367000, 1, 'A10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 416000, 1, 'B3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 367000, 1, 'B4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000004', 0, 367000, 1, 'B6')


INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 200000, 0, 'N1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 200000, 0, 'N3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 200000, 0, 'N6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 200000, 0, 'N8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 200000, 0, 'N9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 200000, 0, 'N11')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 200000, 0, 'N12')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 200000, 0, 'N13')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 391000, 1, 'A1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 344000, 1, 'A2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 346000, 1, 'A6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 391000, 1, 'A7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 344000, 1, 'A8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 346000, 1, 'A9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 391000, 1, 'A10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 344000, 1, 'B2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 1, 346000, 1, 'B10')

INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 328000, 0, 'N2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 332000, 0, 'N4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 328000, 0, 'N5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 332000, 0, 'N7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 328000, 0, 'N10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 332000, 0, 'N14')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 328000, 1, 'A3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 332000, 1, 'A4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 328000, 1, 'A5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 332000, 1, 'B1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 328000, 1, 'B3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 332000, 1, 'B4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 328000, 1, 'B5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 332000, 1, 'B6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 328000, 1, 'B7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 332000, 1, 'B8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000005', 0, 328000, 1, 'B9')


INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 378000, 0, 'N1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 468000, 0, 'N2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 436000, 0, 'N3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 260000, 0, 'N4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 378000, 0, 'N5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 468000, 0, 'N6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 436000, 0, 'N7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 260000, 0, 'N8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 378000, 0, 'N9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 468000, 0, 'N10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 436000, 0, 'N11')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 260000, 0, 'N12')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 378000, 0, 'N13')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 468000, 0, 'N14')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 374000, 1, 'A1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 374000, 1, 'A2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 374000, 1, 'B1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 1, 374000, 1, 'B2')

INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000006', 0, 500000, 1, 'A3')


INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 310000, 0, 'N1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 310000, 0, 'N3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 310000, 0, 'N4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 310000, 0, 'N7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 310000, 0, 'N9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 310000, 0, 'N10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 411000, 1, 'A1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 330000, 1, 'A5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 411000, 1, 'A8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 330000, 1, 'A11')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 411000, 1, 'A15')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 330000, 1, 'B1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 411000, 1, 'B3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 330000, 1, 'B5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 411000, 1, 'B6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 330000, 1, 'B8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 411000, 1, 'B9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 330000, 1, 'B12')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 411000, 1, 'B13')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 1, 330000, 1, 'B14')

INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 386000, 0, 'N2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 386000, 0, 'N5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 386000, 0, 'N6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 386000, 0, 'N8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 386000, 1, 'A2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 386000, 1, 'A3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 386000, 1, 'A4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 432000, 1, 'A6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 330000, 1, 'A7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 432000, 1, 'A9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 330000, 1, 'A10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 432000, 1, 'A12')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 330000, 1, 'A13')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 432000, 1, 'A14')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 330000, 1, 'B2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 432000, 1, 'B4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 330000, 1, 'B7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 432000, 1, 'B10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 330000, 1, 'B11')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000007', 0, 330000, 1, 'B15')


INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 457000, 1, 'A1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 274000, 1, 'A2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 457000, 1, 'A3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 274000, 1, 'A4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 457000, 1, 'A5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 274000, 1, 'A6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 457000, 1, 'A7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 274000, 1, 'A8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 457000, 1, 'A9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 274000, 1, 'A10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 457000, 1, 'A15')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 274000, 1, 'B1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 457000, 1, 'B5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 274000, 1, 'B10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 457000, 1, 'B14')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 1, 274000, 1, 'B15')

INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 343000, 1, 'A11')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 363000, 1, 'A12')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 497000, 1, 'A13')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 343000, 1, 'A14')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 363000, 1, 'A19')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 497000, 1, 'B2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 343000, 1, 'B3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 363000, 1, 'B4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 497000, 1, 'B6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 343000, 1, 'B7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 363000, 1, 'B8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 497000, 1, 'B9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 343000, 1, 'B11')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 363000, 1, 'B12')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000008', 0, 497000, 1, 'B13')


INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 379000, 0, 'N1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 379000, 0, 'N2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 379000, 0, 'N3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 379000, 0, 'N4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 379000, 0, 'N5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 371000, 1, 'A1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 311000, 1, 'A2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 283000, 1, 'A5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 371000, 1, 'A6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 311000, 1, 'A7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 283000, 1, 'A8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 371000, 1, 'A9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 311000, 1, 'B1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 283000, 1, 'B2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 371000, 1, 'B3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 311000, 1, 'B5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 283000, 1, 'B7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 371000, 1, 'B8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 311000, 1, 'B9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 1, 283000, 1, 'B10')

INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 0, 334000, 0, 'N6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 0, 334000, 1, 'A3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 0, 334000, 1, 'A4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 0, 364000, 1, 'A10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 0, 444000, 1, 'B4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000009', 0, 334000, 1, 'B6')


INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 1, 468000, 0, 'N1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 1, 468000, 0, 'N2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 1, 468000, 0, 'N3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 1, 468000, 0, 'N4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 1, 468000, 0, 'N10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 1, 374000, 1, 'A1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 1, 374000, 1, 'A2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 1, 374000, 1, 'A10')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 1, 374000, 1, 'B1')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 1, 374000, 1, 'B10')

INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 432000, 0, 'N5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 432000, 0, 'N6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 432000, 0, 'N7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 432000, 0, 'N8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 432000, 0, 'N9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 432000, 0, 'N11')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 432000, 1, 'A3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 432000, 1, 'A4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 432000, 1, 'A5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 432000, 1, 'A6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 432000, 1, 'A7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 328000, 1, 'A8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 328000, 1, 'A9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 328000, 1, 'B2')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 328000, 1, 'B3')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 328000, 1, 'B4')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 328000, 1, 'B5')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 328000, 1, 'B6')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 328000, 1, 'B7')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 328000, 1, 'B8')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 328000, 1, 'B9')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 328000, 1, 'B11')
INSERT INTO TICKET(id_trip,status,fare,type,seat_number) values ('tri_0000000010', 0, 328000, 1, 'B12')

--
INSERT INTO CASHRESERVE(counter) values ('3055152000')
INSERT INTO CASHRESERVE(counter) values ('3055142000')
INSERT INTO CASHRESERVE(counter) values ('3055132000')
INSERT INTO CASHRESERVE(counter) values ('3055122000')
INSERT INTO CASHRESERVE(counter) values ('3055112000')
INSERT INTO CASHRESERVE(counter) values ('3055102000')
INSERT INTO CASHRESERVE(counter) values ('3055092000')
INSERT INTO CASHRESERVE(counter) values ('3055082000')
INSERT INTO CASHRESERVE(counter) values ('3055072000')
INSERT INTO CASHRESERVE(counter) values ('3055062000')
INSERT INTO CASHRESERVE(counter) values ('3055052000')
INSERT INTO CASHRESERVE(counter) values ('3055042000')
INSERT INTO CASHRESERVE(counter) values ('3055032000')
INSERT INTO CASHRESERVE(counter) values ('3055022000')
INSERT INTO CASHRESERVE(counter) values ('3055012000')
INSERT INTO CASHRESERVE(counter) values ('3055212000')
INSERT INTO CASHRESERVE(counter) values ('3055222000')
INSERT INTO CASHRESERVE(counter) values ('3055232000')
INSERT INTO CASHRESERVE(counter) values ('3055242000')
INSERT INTO CASHRESERVE(counter) values ('3055252000')

--
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000001',16, N'172 Lê Duẩn, TP Buôn Ma Thuột, Đắk Lắk', '0262 393 6868')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000002',17, N'226 Hai Bà Trưng, Nghĩa Thành, Gia Nghĩa, Đắk Nông', '02613 67 67 67')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000003',3, N'QL1A, Khóm 2, P.7, TP.Bạc Liêu, Bạc Liêu', '02913 93 2345')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000004',7, N'Đường Võ Nguyên Giáp, Quốc lộ 60, xã Sơn Đông, Tp. Bến Tre, Tỉnh Bến Tre', '02753646464')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000005',12, N'309 Lý Thường Kiệt, P.6, TP.Cà Mau, Cà Mau', '02903 651 651')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000006',30, N'292 Đinh Bộ Lĩnh, phường 26, Bình Thạnh, Thành phố Hồ Chí Minh', '0283 511 9808')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000007',39, N'695-697, QL20 Liên Nghĩa, H.Đức Trọng, Lâm Đồng', '02633 651 651')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000008',39, N'735 Hùng Vương, TT.Di Linh, H.Di Linh, Lâm Đồng', '02633 788 799')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000009',39, N'280 Trần Phú, TX.Bảo Lộc, Lâm Đồng', '02633 731 731')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000010',34, N'QL80, KP 5, P.Bình San, TX.Hà Tiên, Kiên Giang (BX Hà Tiên)', '02973 66 88 66')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000011',34, N'397 QL 80, KP Ngã ba, TT.Kiên Lương, H.Kiên Lương, Kiên Giang', '02973 769 768')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000012',34, N'QL 80, Tổ 3, KP Kiên Tân, TT.Kiên Lương, H.Kiên Lương, Kiên Giang', '02973 699 688')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000013',31, N'BX Ngã 7, P.Ngã Bảy, TX.Ngã Bảy, Hậu Giang', '02933 868 866')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000014',20, N'Ngã 4 Võ Văn Kiệt - Điện Biên Phủ, P.Thanh An, TX.Hồng Ngự, Đồng Tháp', '02773 898 777')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000015',39, N'795 - QL20 - TT Liên Nghĩa - Huyện Đức Trọng - Lâm Đồng', '19006070')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000016',01, N'QL91, X.Bình Hòa, H.Châu Thành, An Giang', '02963 667 599')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000017',01, N'99 Hàm Nghi, P. Bình Khánh, TP.Long Xuyên, An Giang', '02963 98 9999')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000018',01, N'Bến Phà Vàm Cống,  TP.Long Xuyên, An Giang', '02963 930 967')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000019',01, N'Ngã 3 Lộ Tẻ Tri Tôn, X.Bình Hòa, H.Châu Thành, An Giang', '02963 66 76 56')
Insert into AGENT(id_cash_reserve, id_place, address, phone) values ('cr_0000000020',01, N'Âp Phú Hữu, TT.Phú Hòa, H.Thoại Sơn, An Giang', '02963 878 111')

--
INSERT INTO SYSTEMACCOUNT(username,pass) values ('admin01','admin')
INSERT INTO SYSTEMACCOUNT(username,pass) values ('admin02','admin')
INSERT INTO SYSTEMACCOUNT(username,pass) values ('admin03','admin')
INSERT INTO SYSTEMACCOUNT(username,pass) values ('admin04','admin')
INSERT INTO SYSTEMACCOUNT(username,pass) values ('admin05','admin')



-- 
        
INSERT INTO EMPLOYEE(id_account,id_agent, name,address, phone_number, identity_number, salary, birthdate, gender, state) values ('acc_0000000001','age_0000000005',N'system employee',N'Số 50, đường Nguyễn Tất Thành, phường 5, thành phố Cà Mau, tỉnh Cà Mau','0111111111', '12345678910', 3123, '12-12-2012', 0, 1);
INSERT INTO EMPLOYEE(id_account,id_agent, name,address, phone_number, identity_number, salary, birthdate, gender, state) values ('acc_0000000002','age_0000000004','Le A',N'Số 40, đường Nguyễn Đình Chính, phường 2, thành phố Bến Tre, tỉnh Bến Tre', '0999999999', '12345678910', 5465123, '12-12-2000', 0, 1);
INSERT INTO EMPLOYEE(id_account,id_agent, name,address, phone_number, identity_number, salary, birthdate, gender, state) values ('acc_0000000003','age_0000000003','Nguyen Van B',N'Số 30, đường Lê Lợi, phường 7, thành phố Bạc Liêu, tỉnh Bạc Liêu', '0333333333', '12345678910', 7689368, '12-12-2000', 0, 1);
INSERT INTO EMPLOYEE(id_account,id_agent, name,address, phone_number, identity_number, salary, birthdate, gender, state) values ('acc_0000000004','age_0000000002','Justin C',N'Số 20, đường Hùng Vương, phường Đồng Xuân, thành phố Gia Nghĩa, tỉnh Đăk Nông', '0555555555', '12345678910', 5367852, '12-12-2000', 1, 1);
INSERT INTO EMPLOYEE(id_account,id_agent, name,address, phone_number, identity_number, salary, birthdate, gender, state) values ('acc_0000000005','age_0000000001','Lucky D',N'Số 10, đường Y Ngông, phường Tân Lợi, thành phố Buôn Ma Thuột, tỉnh Đăk Lăk', '0888888888', '12345678910', 5465123, '12-12-2000', 1, 1);

--
exec pro_AssignSystemPrivilege 'emp_0000000001',  'pos_0000000001'
--
insert into POSITION(type) values ('administrator');
insert into POSITION(type) values ('planner');
insert into POSITION(type) values ('supervisor');
insert into POSITION(type) values ('ticket seller');
insert into POSITION(type) values ('driver');
insert into POSITION(type) values ('service guide');
insert into POSITION(type) values ('security guard');
insert into POSITION(type) values ('porter');
--
--
-- DRIVER
insert into DRIVER values('emp_0000000005', 'F', 0, 0);


--
--use busmanagement
--go
----
--drop user cuongle123
--drop user admin01
--drop user admin02
--drop user admin03
--drop user admin04
--drop user admin05
--drop user cuongleok
--go
----
--drop login cuongle123
--drop login admin01
--drop login admin02
--drop login admin03
--drop login admin04
--drop login admin05
--drop login cuongleok
--go
----
--create login cuongle123 with password='123a', default_database=[BusManagement], check_expiration = off, check_policy = off
--create login admin01 with password='admin', default_database=[BusManagement], check_expiration = off, check_policy = off
--create login admin02 with password='admin', default_database=[BusManagement], check_expiration = off, check_policy = off
--create login admin03 with password='admin', default_database=[BusManagement], check_expiration = off, check_policy = off
--create login admin04 with password='admin', default_database=[BusManagement], check_expiration = off, check_policy = off
--create login admin05 with password='admin', default_database=[BusManagement], check_expiration = off, check_policy = off
--create login cuongleok with password='123a', default_database=[BusManagement], check_expiration = off, check_policy = off

--go
----

--create user cuongle123 for login cuongle123
--create user cuongleok for login cuongleok
--create user admin01 for login admin01
--create user admin02 for login admin02
--create user admin03 for login admin03
--create user admin04 for login admin04
--create user admin05 for login admin05


--exec sp_addrolemember rol_Passenger, cuongle123
--exec sp_addrolemember rol_Passenger, cuongleok
--exec sp_addrolemember rol_Admin, admin01
--exec sp_addrolemember rol_Staff, admin02
--exec sp_addrolemember rol_Staff, admin03
--exec sp_addrolemember rol_Staff, admin04
--exec sp_addrolemember rol_Staff, admin05