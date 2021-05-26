export interface PersonAddress {
  addressId: number;
  personId: number;
  companyId: number;
  primary: boolean;
  phone: string;
  extension: string;
  fax: string;
  addressType: number;
  address1: string;
  address2: string;
  city: string;
  state: number;
  zip: string;
  countryId: number;
  addressTypeDesc: string;
  stateName: string;
  countryName: string;
}
