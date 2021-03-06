CREATE USER nsi_user WITH ENCRYPTED PASSWORD 'nsi_pass';

-- payments
CREATE DATABASE nsi_payments;
GRANT ALL PRIVILEGES ON DATABASE nsi_payments TO nsi_user;

--hangfire
CREATE DATABASE nsi_jobs;
GRANT ALL PRIVILEGES ON DATABASE nsi_jobs TO nsi_user;

--policy
CREATE DATABASE nsi_policy;
GRANT ALL PRIVILEGES ON DATABASE nsi_policy TO nsi_user;

--pricing
CREATE DATABASE nsi_pricing;
GRANT ALL PRIVILEGES ON DATABASE nsi_pricing TO nsi_user;


