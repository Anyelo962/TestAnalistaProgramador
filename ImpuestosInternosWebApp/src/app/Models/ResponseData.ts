import { Contributordata } from 'src/app/Models/Contributor' 

export interface ResponseData {
    $id: string;
    $values: Contributordata[];
    message: string;
    success: boolean;
  }