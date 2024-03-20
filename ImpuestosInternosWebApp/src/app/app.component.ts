import { Component, OnInit } from '@angular/core';
import { Contributordata} from 'src/app/Models/Contributor'
import {ContributorService} from "src/app/Services/contributor.service"
import {ResponseData} from 'src/app/Models/ResponseData'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'ImpuestosInternosWebApp';
  items: Contributordata[] | undefined;

  ngOnInit() {
    
  this.contributor.getAllContributor().subscribe((data) => {
      this.items = data
      console.log(this.items)
    },
    error => (
      console.log
    ));
  }

  toggleSublist(event: Event): void {
    const target = event.currentTarget as HTMLElement;
    target.parentElement?.classList.toggle('open');
  }

  constructor(private contributor: ContributorService) { }


}
