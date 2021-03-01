import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { Contapagar } from 'src/app/models/contapagar.model';
import { ContapagarService } from 'src/app/services/contapagar.service';

@Component({
  selector: 'app-contapagar-list',
  templateUrl: './contapagar-list.component.html',
  styleUrls: ['./contapagar-list.component.css']
})
export class ContapagarListComponent implements OnInit {
  contas?: Contapagar[];

  constructor(
    private service: ContapagarService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    this.list();
  }

  list(): void {
    this.service.list()
      .subscribe(
        data => {
          this.contas = data;
        },
        error => {
          console.log(error);
        });
  }

  refreshList(): void {
    this.list();
  }

  delete(id: number): void {
    this.router.navigate([`/contapagar/delete/${id}`]);
  }

  detail(id: number): void {
    this.router.navigate([`/contapagar/detail/${id}`]);
  }

}
