import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { Contapagar } from 'src/app/models/contapagar.model';
import { ContapagarService } from 'src/app/services/contapagar.service';

@Component({
  selector: 'app-contapagar-detail',
  templateUrl: './contapagar-detail.component.html',
  styleUrls: ['./contapagar-detail.component.css']
})
export class ContapagarDetailComponent implements OnInit {
  conta: Contapagar = new Contapagar();
  notFound: boolean = false;

  constructor(
    private service: ContapagarService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    this.get(this.route.snapshot.params.id);
  }

  get(id: number): void {
    this.notFound = false;

    this.service.find(id)
      .subscribe(
        data => {
          if (data) {
            this.conta = data;
          } 
          else {
            this.notFound = true;
          }
        },
        error => {
          this.notFound = true;
          console.log(error);
        });
  }
}
