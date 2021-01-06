CREATE USER user WITH ENCRYPTED PASSWORD 'password';

CREATE DATABASE insurance_payments;
GRANT ALL PRIVILEGES ON DATABASE insurance_payments TO user;

CREATE DATABASE insurance_jobs;
GRANT ALL PRIVILEGES ON DATABASE insurance_jobs TO user;

CREATE DATABASE insurance_policy;
GRANT ALL PRIVILEGES ON DATABASE insurance_policy TO user;

CREATE DATABASE insurance_pricing;
GRANT ALL PRIVILEGES ON DATABASE insurance_pricing TO user;


