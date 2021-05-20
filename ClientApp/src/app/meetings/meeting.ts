export interface Meeting {
  meetingCode: string;    //required
  meetingStartDate: Date; //required
  meetingEndDate: Date;   //required
  meetingDesc: string;    //required

  //for edit screens:
  meetingStartTime: Date; //required
  meetingEndTime: Date;   //required
  longDescription: string;  //required
  meetingLocation: string;  //required
  meetingInstructions: string;
  etrakMeetingImage: string;        //is this really used? I don't think etrak is using an image?
  earlyCancellationAmt: number;
  cancellationDate: Date;
  lateCancellationAmt: number;
  sponsor: string;
  meetingDetailUrl: string;
  gmtOffset: number;
  allowWebReg: boolean;
  allowWebGuests: boolean;
  webSortOrder: number;           //is this really used? I don't think etrak is checking this field?
  useHousingCosts: boolean;       //this will always be false; the field is not used but the value is required on the database table
  useItineraryCosts: boolean;     //this will always be false; the field is not used but the value is required on the database table
  sponsoredBy: number;

}
