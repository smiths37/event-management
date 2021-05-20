export interface CompanyNote {
  noteDate: Date;
  followUpDate: Date;
  personResponsible: string;
  notes: string;
  dateCompleted: Date;
  completedBy: string;
  companyId: number;
  noteId: number;
}
