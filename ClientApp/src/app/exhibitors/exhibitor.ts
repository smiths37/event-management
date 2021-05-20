export interface Exhibitor {
  exhibitorId: number;
  companyId: number;
  personId: number;
  meetingCode: string;
  numberOfBooths: number;
  costPerBooth: number;
  totalCost: number;    
  depositAmount: number;
  balanceDue: number;   
  boothLoc1: string;
  boothLoc2: string;
  boothLoc3: string;
  boothLoc4: string;
  sponsoredEvents: string;
  depositReceived: Date;
  confirmationSent: Date;
  profile: string;
  sourceId: number;
  meetingDesc: string;
  meetingLocation: string;
  meetingStartDate: Date;
  meetingEndDate: Date;
  companyName: string;
  personFirstName: string;
  personLastName: string;
 

  //Not used: packetSent

}
