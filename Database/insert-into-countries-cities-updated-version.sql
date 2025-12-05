-----------------------------------------
-- 1) ≈÷«›… ⁄„Êœ CountryCode ·ÃœÊ· «·„œ‰
-----------------------------------------
ALTER TABLE Cities
ADD CountryCode NVARCHAR(10);

-----------------------------------------
-- 3) Ã⁄· «·⁄„Êœ NOT NULL
-----------------------------------------
ALTER TABLE Cities
ALTER COLUMN CountryCode NVARCHAR(10) NOT NULL;

-----------------------------------------
-- 4) ≈÷«›… ﬁÌœ Foreign Key
-----------------------------------------
ALTER TABLE Cities
ADD CONSTRAINT FK_Cities_Countries
FOREIGN KEY (CountryCode)
REFERENCES Countries (CountryCode)
ON DELETE CASCADE;
GO


-----------------------------------------
-- 5) ≈œŒ«· «·œÊ·
-----------------------------------------
INSERT INTO Countries (CountryCode, CountryName) VALUES
('KSA', N'«·„„·ﬂ… «·⁄—»Ì… «·”⁄ÊœÌ…'),
('UAE', N'«·≈„«—«  «·⁄—»Ì… «·„ Õœ…'),
('BHR', N'«·»Õ—Ì‰'),
('KWT', N'«·ﬂÊÌ '),
('QAT', N'ﬁÿ—'),
('OMN', N'”·ÿ‰… ⁄ı„«‰'),
('YEM', N'«·Ì„‰');
GO


-----------------------------------------
-- 6) ≈œŒ«· «·„œ‰ ··Ì„‰
-----------------------------------------
INSERT INTO Cities (CityCode, CityName, CountryCode) VALUES
('SN', N'’‰⁄«¡', 'YEM'),
('AD', N'⁄œ‰', 'YEM'),
('TZ', N' ⁄“', 'YEM'),
('HD', N'«·ÕœÌœ…', 'YEM'),
('IB', N'≈»', 'YEM'),
('DH', N'–„«—', 'YEM'),
('AM', N'⁄„—«‰', 'YEM'),
('SH', N'‘»Ê…', 'YEM'),
('MR', N'„√—»', 'YEM'),
('HW', N'ÕÃ…', 'YEM'),
('MU', N'«·„ÕÊÌ ', 'YEM'),
('JA', N'«·ÃÊ›', 'YEM'),
('BY', N'«·»Ì÷«¡', 'YEM'),
('DR', N'«·÷«·⁄', 'YEM'),
('LA', N'·ÕÃ', 'YEM'),
('AB', N'√»Ì‰', 'YEM'),
('HA', N'Õ÷—„Ê ', 'YEM'),
('SO', N'”ﬁÿ—Ï', 'YEM'), 
('RA', N'—Ì„…', 'YEM'),
('SD', N'’⁄œ…', 'YEM'),
('MAH', N'«·„Â—…', 'YEM');
GO


-----------------------------------------
-- 7) «·”⁄ÊœÌ… (KSA)
-----------------------------------------
INSERT INTO Cities (CityCode, CityName, CountryCode) VALUES
('RIY', N'«·—Ì«÷', 'KSA'),
('JED', N'Ãœ…', 'KSA'),
('MED', N'«·„œÌ‰… «·„‰Ê—…', 'KSA'),
('DMM', N'«·œ„«„', 'KSA'),
('MKA', N'„ﬂ… «·„ﬂ—„…', 'KSA'),
('TIF', N'«·ÿ«∆›', 'KSA'),
('ABH', N'√»Â«', 'KSA'),
('TAB', N' »Êﬂ', 'KSA'),
('HAI', N'Õ«∆·', 'KSA'),
('JFN', N'Ã«“«‰', 'KSA');
GO


-----------------------------------------
-- 8) «·≈„«—«  (UAE)
-----------------------------------------
INSERT INTO Cities (CityCode, CityName, CountryCode) VALUES
('DXB', N'œ»Ì', 'UAE'),
('AUH', N'√»ÊŸ»Ì', 'UAE'),
('SHJ', N'«·‘«—ﬁ…', 'UAE'),
('AJM', N'⁄Ã„«‰', 'UAE'),
('RAK', N'—√” «·ŒÌ„…', 'UAE'),
('FJR', N'«·›ÃÌ—…', 'UAE'),
('UAQ', N'√„ «·ﬁÌÊÌ‰', 'UAE');
GO


-----------------------------------------
-- 9) «·»Õ—Ì‰ (BHR)
-----------------------------------------
INSERT INTO Cities (CityCode, CityName, CountryCode) VALUES
('MNM', N'«·„‰«„…', 'BHR'),
('RIF', N'«·—›«⁄', 'BHR'),
('MUH', N'«·„Õ—ﬁ', 'BHR');
GO


-----------------------------------------
-- 10) «·ﬂÊÌ  (KWT)
-----------------------------------------
INSERT INTO Cities (CityCode, CityName, CountryCode) VALUES
('KW',  N'„œÌ‰… «·ﬂÊÌ ', 'KWT'),
('HWF', N'ÕÊ·Ì', 'KWT'),
('FAR', N'«·›—Ê«‰Ì…', 'KWT'),
('JAH', N'«·ÃÂ—«¡', 'KWT'),
('MUB', N'„»«—ﬂ «·ﬂ»Ì—', 'KWT'),
('AHM', N'«·√Õ„œÌ', 'KWT');
GO


-----------------------------------------
-- 11) ﬁÿ— (QAT)
-----------------------------------------
INSERT INTO Cities (CityCode, CityName, CountryCode) VALUES
('DOH', N'«·œÊÕ…', 'QAT'),
('WKR', N'«·Êﬂ—…', 'QAT'),
('KHO', N'«·ŒÊ—', 'QAT'),
('RAY', N'«·—Ì«‰', 'QAT'),
('SHA', N'«·‘Õ«‰Ì…', 'QAT');
GO


-----------------------------------------
-- 12) ⁄ı„«‰ (OMN)
-----------------------------------------
INSERT INTO Cities (CityCode, CityName, CountryCode) VALUES
('MUS', N'„”ﬁÿ', 'OMN'),
('SAL', N'’·«·…', 'OMN'),
('SUH', N'’Õ«—', 'OMN'),
('NIZ', N'‰“ÊÏ', 'OMN'),
('BHW', N'»Â·«', 'OMN'),
('IBR', N'⁄»—Ì', 'OMN');
GO
