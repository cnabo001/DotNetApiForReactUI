BEGIN TRANSACTION;

INSERT INTO Item (Id, ConcurrencyStamp, CreateDate, DeletedBy, DeletedDate, Description, IsActive, Price, Title, UpdateDate) VALUES
-- Laptops / Endpoints
('3b5b3c9d-2e7e-4b2a-9d71-8f9b9b6f0a11','c42efb9d7c3e4f39a9f2b6abf6b10101','2025-01-15T09:00:00Z',NULL,NULL,'Enterprise laptop, 32GB RAM, 1TB NVMe, Win 11 Enterprise',0,1899.00,'ThinkPad T14 Gen 5','2025-01-15T09:00:00Z'),
('5f893f4a-1a9a-4d2e-8c2c-1a0c0f7f2b22','2f0f5f2b88d74e5a9c3da04a31810102','2025-01-15T09:00:00Z',NULL,NULL,'Mobile workstation, i9, 64GB RAM, RTX A2000, 2TB NVMe',0,2999.00,'Dell Precision 5680','2025-01-15T09:00:00Z'),
('0c9f8b67-7a7a-4a1e-bf1a-75c0f922e533','d4270a5b1c0d4b14a3c8fbdcc0e10103','2025-01-15T09:00:00Z',NULL,NULL,'Lightweight ultrabook, 16GB/512GB, Wi-Fi 6E',0,1299.00,'HP EliteBook 840 G11','2025-01-15T09:00:00Z'),

-- Servers / Compute
('a6e8e8a1-6f5e-4f2d-9d35-2c7c0a70e644','f5b2c3d4148e4f409a1b0e67b8e10104','2025-01-15T09:05:00Z',NULL,NULL,'1U rack server, 2×Xeon, 256GB RAM, 8×3.84TB SSD (RAID10)',0,21990.00,'HPE ProLiant DL360 Gen11','2025-01-15T09:05:00Z'),
('b7c4c5d6-7e8f-4a90-b2c1-3d4e5f607755','a9e87c2f33e24ad7b0b76c0cc6a10105','2025-01-15T09:05:00Z',NULL,NULL,'2U GPU server, 2×AMD EPYC, 4×A100 80GB, 1TB RAM',0,149000.00,'Lenovo ThinkSystem SR670 V2','2025-01-15T09:05:00Z'),

-- Networking
('c8d9ea0b-1c2d-4e3f-9a0b-6f7e8d9c0876','e1c2d3f4a5b647c7d8e9f0a1b2c10106','2025-01-15T09:10:00Z',NULL,NULL,'Enterprise core switch, 48×10Gb, 6×40Gb QSFP+',0,21999.00,'Cisco Catalyst 9500','2025-01-15T09:10:00Z'),
('dd7b8148-0d57-4b21-ae64-7403d7d40b77','0f1e2d3c4b5a4698a7b6c5d4e3f10107','2025-01-15T09:10:00Z',NULL,NULL,'NGFW appliance, 10Gb throughput, IPS/AV/URL filtering',0,12999.00,'Palo Alto PA-3410','2025-01-15T09:10:00Z'),
('ef98c7b6-5a43-4a32-9a21-0f9e8d7c6b88','11aa22bb33cc44dd55ee66ff77a10108','2025-01-15T09:10:00Z',NULL,NULL,'WAN edge SD-WAN router, dual LTE, 1Gb failover',0,4999.00,'Cisco Catalyst 8200','2025-01-15T09:10:00Z'),

-- Storage
('f0a1b2c3-d4e5-46f7-a8b9-c0d1e2f3a499','8899aabbccddeeff0011223344510109','2025-01-15T09:12:00Z',NULL,NULL,'All-flash array, 200TB effective, NVMe/TCP',0,89999.00,'Pure Storage FlashArray//X20','2025-01-15T09:12:00Z'),
('10b2c3d4-e5f6-4708-9012-13a2b3c4d5aa','66778899aabbccddeeff001122561011','2025-01-15T09:12:00Z',NULL,NULL,'Backup appliance, 80TB usable, immutability',0,36999.00,'Cohesity C4000','2025-01-15T09:12:00Z'),

-- Software licenses
('21c3d4e5-f607-4819-9132-24b3c4d5e6bb','74b0790e2c8d4c8ba5b4c2c5a0e10112','2025-01-15T09:15:00Z',NULL,NULL,'Windows Server Datacenter, 16-core license',0,6155.00,'MS Windows Server DC 2022','2025-01-15T09:15:00Z'),
('32d4e5f6-0718-492a-a243-35c4d5e6f7cc','5b7a6c1de9f5446e96a9a8e3d0e10113','2025-01-15T09:15:00Z',NULL,NULL,'SQL Server Enterprise, 16-core license',0,59847.00,'MS SQL Server 2022 Ent','2025-01-15T09:15:00Z'),
('43e5f607-1829-4a3b-b354-46d5e6f708dd','9a8b7c6d5e4f4d3c2b1a0f9e8d710114','2025-01-15T09:15:00Z',NULL,NULL,'VMware vSphere Enterprise Plus (per CPU)',0,3995.00,'vSphere Ent+ License','2025-01-15T09:15:00Z'),

-- SaaS / Cloud credits
('54f60718-293a-4b4c-c465-57e6f70819ee','11223344556677889900aabbcc701015','2025-01-15T09:17:00Z',NULL,NULL,'Azure monetary credits – Enterprise Agreement',0,10000.00,'Azure EA Credits (10K)','2025-01-15T09:17:00Z'),
('65f71829-3a4b-4c5d-d576-68f708192aef','00ffeeddccbbaa998877665544881016','2025-01-15T09:17:00Z',NULL,NULL,'GitHub Enterprise Cloud – 50 seats (annual)',0,12000.00,'GitHub Enterprise Cloud (50)','2025-01-15T09:17:00Z'),

-- Security / Identity
('76f8293a-4b5c-4d6e-e687-79f8192a3bff','aa33bb44cc55dd66ee77ff8800991017','2025-01-15T09:20:00Z',NULL,NULL,'Endpoint protection EDR (1000 endpoints, annual)',0,45000.00,'CrowdStrike Falcon Complete (1000)','2025-01-15T09:20:00Z'),
('87f93a4b-5c6d-4e7f-f798-80f92a3b4c10','1a2b3c4d5e6f708192a3b4c5d6e10118','2025-01-15T09:20:00Z',NULL,NULL,'Okta Workforce Identity Cloud – 500 users (annual)',0,36000.00,'Okta WIC (500)','2025-01-15T09:20:00Z'),

-- Collaboration / Productivity
('98fa4b5c-6d7e-4f80-0819-91fa2b3c4d21','abcdefabcdefabcdefabcdefabcd1019','2025-01-15T09:22:00Z',NULL,NULL,'Microsoft 365 E5 – 250 seats (annual)',0,99000.00,'M365 E5 (250)','2025-01-15T09:22:00Z'),
('a90b5c6d-7e8f-4f91-192a-a20b3c4d5e32','bada55bada55bada55bada55bada1020','2025-01-15T09:22:00Z',NULL,NULL,'Atlassian Cloud – Jira/Confluence (100 users, annual)',0,16800.00,'Atlassian Cloud (100)','2025-01-15T09:22:00Z'),

-- Licenses / Support
('b01c6d7e-8f90-4012-2a3b-b30c4d5e6f43','feedfacefeedfacefeedfacefeed1021','2025-01-15T09:24:00Z',NULL,NULL,'Red Hat Enterprise Linux – 2 sockets, Standard (annual)',0,1599.00,'RHEL Std (2S)','2025-01-15T09:24:00Z'),
('c12d7e8f-9012-4123-3b4c-c40d5e6f7044','deadc0dedeadc0dedeadc0dedead1022','2025-01-15T09:24:00Z',NULL,NULL,'Premium vendor support for storage array (24×7, annual)',0,8999.00,'Storage Premium Support','2025-01-15T09:24:00Z'),

-- Peripherals / Infra parts
('d23e8f90-0123-4234-4c5d-d50e6f708155','cafebabecafebabecafebabecafe1023','2025-01-15T09:26:00Z',NULL,NULL,'2U rack rails – adjustable, 500mm–800mm',0,129.00,'Universal Rack Rails','2025-01-15T09:26:00Z'),
('e34f9012-1234-4345-5d6e-e60f8192a266','c001d00dc001d00dc001d00dc0011024','2025-01-15T09:26:00Z',NULL,NULL,'800W hot-swap power supply module',0,399.00,'PSU Module 800W','2025-01-15T09:26:00Z'),
('f4501234-2345-4456-6e7f-f70f92a3b377','faceb00cfaceb00cfaceb00cface1025','2025-01-15T09:26:00Z',NULL,NULL,'LC-LC multimode fiber, OM4, 10m',0,32.50,'Fiber Patch OM4 10m','2025-01-15T09:26:00Z'),

-- Monitoring / Observability
('05112345-3456-4567-7081-0819a2b3c488','00aa11bb22cc33dd44ee55ff66771026','2025-01-15T09:28:00Z',NULL,NULL,'Datadog APM – 50 hosts (annual)',0,18000.00,'Datadog APM (50)','2025-01-15T09:28:00Z'),
('16223456-4567-4678-8192-192a3b4c5d99','77889900aabbccddeeff112233441027','2025-01-15T09:28:00Z',NULL,NULL,'New Relic Full-Stack – 50 hosts (annual)',0,14500.00,'New Relic FS (50)','2025-01-15T09:28:00Z'),

-- Certificates / PKI
('27334567-5678-4789-92a3-2a3b4c5d6e10','aa77bb88cc99ddee00ff112233441028','2025-01-15T09:30:00Z',NULL,NULL,'Public TLS wildcard cert *.corp.example.com (2-year)',0,899.00,'Wildcard TLS Cert (2y)','2025-01-15T09:30:00Z'),

-- Backup/DR subscriptions
('38445678-6789-489a-a3b4-3b4c5d6e7f21','1234567890abcdef1234567890ab1029','2025-01-15T09:32:00Z',NULL,NULL,'Veeam Backup & Replication Enterprise (per socket, annual)',0,4200.00,'Veeam B&R Ent (2S)','2025-01-15T09:32:00Z'),
('49556789-789a-49ab-b4c5-4c5d6e7f8032','abcdef1234567890abcdef1234561030','2025-01-15T09:32:00Z',NULL,NULL,'DRaaS subscription – 10TB protected, quarterly test',0,12500.00,'DRaaS 10TB','2025-01-15T09:32:00Z'),

-- Telemetry / Logging
('5a66789a-89ab-4abc-c5d6-5d6e7f809143','99887766554433221100ffeeddcc1031','2025-01-15T09:34:00Z',NULL,NULL,'Splunk Enterprise – ingest 100GB/day (annual)',0,95000.00,'Splunk Ent 100GB/d','2025-01-15T09:34:00Z'),

-- Endpoint add-ons
('6b7789ab-9abc-4bcd-d6e7-6e7f80915254','a1a2a3a4a5b6b7b8b9c0c1c2c3c41032','2025-01-15T09:36:00Z',NULL,NULL,'Docking station, dual 4K, 100W PD',0,289.99,'USB-C Dock Pro','2025-01-15T09:36:00Z'),
('7c889abc-abcd-4cde-e7f8-7f8091526375','0a1b2c3d4e5f60718293a4b5c6d71033','2025-01-15T09:36:00Z',NULL,NULL,'Noise-canceling headset with boom mic',0,189.00,'Jabra Evolve2 65','2025-01-15T09:36:00Z'),

-- Licenses – Dev/Test
('8d99abcd-bcde-4def-f809-809152637486','13579bdf2468ace013579bdf24681034','2025-01-15T09:38:00Z',NULL,NULL,'JetBrains All Products Pack – 10 seats (annual)',0,2390.00,'JetBrains APP (10)','2025-01-15T09:38:00Z'),
('9ea0bcde-cdef-4f01-0819-915263748597','2468ace013579bdf2468ace013571035','2025-01-15T09:38:00Z',NULL,NULL,'Postman Enterprise – 25 seats (annual)',0,6000.00,'Postman Ent (25)','2025-01-15T09:38:00Z'),

-- Misc enterprise line items
('af10cdef-def0-4102-192a-a152637485a8','3141592653589793238462643383271036','2025-01-15T09:40:00Z',NULL,NULL,'Smartcard readers – USB-A, CAC/PIV compliant (50pcs)',0,1450.00,'CAC/PIV Reader (50)','2025-01-15T09:40:00Z'),
('b021def0-ef01-4213-2a3b-b26374859ab9','2718281828459045235360287471351037','2025-01-15T09:40:00Z',NULL,NULL,'Privileged access vault license – 25 admins (annual)',0,18000.00,'PAM Vault (25)','2025-01-15T09:40:00Z'),
('c132ef01-f012-4324-3b4c-c374859abcca','1618033988749894848204586834361038','2025-01-15T09:42:00Z',NULL,NULL,'SaaS SSO connector add-on (annual)',0,4800.00,'SSO Add-on','2025-01-15T09:42:00Z'),
('d243f012-0013-4435-4c5d-d4859abccddb','1414213562373095048801688724201039','2025-01-15T09:42:00Z',NULL,NULL,'Hardware security module (HSM) cloud subscription',0,7200.00,'HSM Cloud Sub','2025-01-15T09:42:00Z');

COMMIT;
