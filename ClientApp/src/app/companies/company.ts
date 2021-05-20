export interface Company {
  companyId: number;
  companyName: string;
  parentCompanyID: number;
  parentName: string;
  alphaindexName: string;
  companyType: number;
  dateEntered: string;
  enteredBy: string;
  dateUpdated: string;
  updatedBy: string;
  addressId: number;
  sourceId: number;
  addresses: string[];    //do i need this?
}
