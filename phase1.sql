CREATE DATABASE plths;

use plths;


CREATE TABLE [dbo].[Purok] (
    [Purok_Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Purok_Nane]   VARCHAR (50)  NULL,
    [Purok_Leader] VARCHAR (50)  NULL,
    [Contact]      NVARCHAR (50) NULL,
    CONSTRAINT [PK_Purok] PRIMARY KEY CLUSTERED ([Purok_Id] ASC)
);

CREATE TABLE [dbo].[Residents] (
    [ID]              INT           IDENTITY (1, 1) NOT NULL,
    [Lastname]        VARCHAR (50)  NULL,
    [Firstname]       VARCHAR (50)  NULL,
    [Middlename]      VARCHAR (50)  NULL,
    [Gender]          VARCHAR (50)  NULL,
    [Age]             INT           NULL,
    [Mobile]          NVARCHAR (50) NULL,
    [Email]           VARCHAR (250) NULL,
    [Birthdate]       DATE          NULL,
    [Religion]        VARCHAR (50)  NULL,
    [Citizenship]     VARCHAR (50)  NULL,
    [PurokID]           INT  NULL,
    [Adress]          VARCHAR (250) NULL,
    [Profession]      VARCHAR (50)  NULL,
    [Dialect]         VARCHAR (50)  NULL,
    [civil_status]          VARCHAR (50)  NULL,
    [status]          VARCHAR (50)  NULL,
    [filename]        VARCHAR (MAX) NULL,
    [F_Lname]         VARCHAR (50)  NULL,
    [F_Mname]         VARCHAR (50)  NULL,
    [F_Fname]         VARCHAR (50)  NULL,
    [M_Lname]         VARCHAR (50)  NULL,
    [M_Mname]         VARCHAR (50)  NULL,
    [M_Finame]        VARCHAR (50)  NULL,
    [Voter_id]        NVARCHAR (50) NULL,
    [Precint_No]      NVARCHAR (50) NULL,
    [e_attainment]    VARCHAR (50)  NULL,
    [beneficiary]     VARCHAR (50)  NULL,
    [fullname]        VARCHAR (50)  NULL,
    [father_fullname] VARCHAR (100) NULL,
    [mother_fullname] VARCHAR (50)  NULL,
    CONSTRAINT [PK_Residents] PRIMARY KEY CLUSTERED ([ID] ASC)
);


CREATE TABLE [dbo].[Indigency] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [ResidentID]    INT  NULL,
    [Purpose]  VARCHAR (30)  NULL,
    [amount]   INT           NULL,
    [Issuance] VARCHAR (MAX) NULL,
    [date]     VARCHAR (50)  NULL,
    CONSTRAINT [PK_Indigency] PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Clearance] (
    [clearance_id] INT           IDENTITY (1, 1) NOT NULL,
    [ResidentID]          INT           NULL,
    [Issued]       VARCHAR (MAX) NULL,
    [status]       VARCHAR (50)  NULL,
    [date]         DATE          NULL,
    CONSTRAINT [PK_Clearance] PRIMARY KEY CLUSTERED ([clearance_id] ASC)
);

CREATE TABLE [dbo].[business_permit] (
    [permit_id]     INT           IDENTITY (1, 1) NOT NULL,
    [name]          VARCHAR (50)  NULL,
    [ResidentID]          INT           NULL,
    [business_name] VARCHAR (50)  NULL,
    [location]      VARCHAR (50)  NULL,
    [Issued_on]     VARCHAR (MAX) NULL,
    [amount]        INT           NULL,
    [expiration]    DATE          NULL,
    [date]          VARCHAR (50)  NULL,
    CONSTRAINT [PK_business_permit_1] PRIMARY KEY CLUSTERED ([permit_id] ASC)
);

CREATE TABLE [dbo].[Issued_place] (
    [issuedPlace_id] INT          IDENTITY (1, 1) NOT NULL,
    [place_name]     VARCHAR (50) NULL,
    CONSTRAINT [PK_Issued_place] PRIMARY KEY CLUSTERED ([issuedPlace_id] ASC)
);

CREATE TABLE [dbo].[Missing] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Firstname]   VARCHAR (30)  NULL,
    [Middlename]  VARCHAR (30)  NULL,
    [Lastname]    VARCHAR (30)  NULL,
    [Age]         INT           NULL,
    [Gender]      VARCHAR (10)  NULL,
    [Adress]      VARCHAR (50)  NULL,
    [Description] NVARCHAR (50) NULL,
    [DateMissing] DATE          NULL,
    [DateFound]   NVARCHAR (50) NULL,
    [Status]      VARCHAR (30)  NULL,
    [Image]       VARCHAR (MAX) NULL,
    [Reported]    VARCHAR (30)  NULL,
    [Contact_num] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Missing] PRIMARY KEY CLUSTERED ([ID] ASC)
);



CREATE TABLE [dbo].[frmBlotterReport] (
    [BlotterNo]           INT           IDENTITY (1, 1) NOT NULL,
    [IncidentLocation]    VARCHAR (MAX) NULL,
    [IncidentType]        VARCHAR (50)  NULL,
    [DTIncident]          VARCHAR (50)  NULL,
    [DTReported]          VARCHAR (50)  NULL,
    [IncidentNarrative]   VARCHAR (MAX) NULL,
    [Complainant]         VARCHAR (50)  NULL,
    [Complained_Resident] VARCHAR (50)  NULL,
    [StatusC]             VARCHAR (50)  NULL,
    [NickNameC]           VARCHAR (50)  NOT NULL,
    [Citizenshipc]        VARCHAR (50)  NULL,
    [GenderC]             VARCHAR (50)  NULL,
    [AgeC]                INT           NULL,
    [MobileC]             NVARCHAR (50) NULL,
    [AdressC]             VARCHAR (250) NULL,
    [NickNameP]           VARCHAR (50)  NULL,
    [CitizenshipP]        VARCHAR (50)  NULL,
    [GenderP]             VARCHAR (50)  NULL,
    [AgeP]                INT           NULL,
    [MobileP]             NVARCHAR (50) NULL,
    [AdressP]             VARCHAR (250) NULL,
    [Office_in_Charge]    VARCHAR (50)  NULL,
    [Purok]               VARCHAR (50)  NULL,
    [DOB_C]               DATE          NULL,
    [DOB_CR]              DATE          NULL,
    [Purok_C]             VARCHAR (50)  NULL,
    [C_fname]             VARCHAR (20)  NULL,
    [C_mname]             VARCHAR (50)  NULL,
    [C_lname]             VARCHAR (50)  NULL,
    [P_fname]             VARCHAR (50)  NULL,
    [P_mname]             VARCHAR (50)  NULL,
    [P_lname]             VARCHAR (50)  NULL,
    [Signature_1]         VARCHAR (MAX) NULL,
    [Signature_2]         VARCHAR (MAX) NULL,
    CONSTRAINT [PK_frmBlotterReport] PRIMARY KEY CLUSTERED ([BlotterNo] ASC)
);