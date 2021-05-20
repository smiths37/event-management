export interface Person {
  personId: number;
  namePrefix: string;
  firstName: string;    //cannot be null
  middle: string;
  lastName: string;     //cannot be null
  nameSuffix: string;
  ssn: string;          //will be used to store bar # instead
  companyId: number;
  companyName: string;
  title: string;
  dept: string;
  addressId: string;
  primaryContact: boolean;  //cannot be null, but will always be 0
  dateEntered: Date;
  badgeName: string;
  salutation: string;
  peopleType: number;
  contactType: number;
  sourceId: number;
  email: string;
  mailPref: string;
  doNotMail: boolean;
  cellPhone: string;
  user1: string;        //updated/reason field
  user2: string;        //association field
  user3: string;        //level field
  user4: string;        //appointed/elected/hired field
  user5: string;        //assumed office field
  user6: string;        //resigned/terminated field
  formalTitle: string;
  judgeId: string;
  basic: Date;
  advance: Date;
  distinguished: Date;
  outstanding: Date;
  SCtNJC: Date;
  CCMDate: Date;
  CCEDate: Date;
  CEDPDate: Date;
  ICMReport: string;
  faculty: Date;

  peopleTypeDesc: string;
  contactTypeDesc: string;


  //Not used, but cannot be null in the database (so will always be false):
  sellName: boolean;        
  includeInDirectory: boolean;
  includeInMemDirectory: boolean;

  //not used and can be null in the database: refId, photo, directorySortOrder, memSortOrder, specialtyId, pager, disclaimerExpDate, peopleSourceCode 
}
