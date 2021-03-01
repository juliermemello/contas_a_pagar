import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { ContapagarService } from 'src/app/services/contapagar.service';

@Component({
  selector: 'app-contapagar-delete',
  templateUrl: './contapagar-delete.component.html',
  styleUrls: ['./contapagar-delete.component.css']
})
export class ContapagarDeleteComponent implements OnInit {
  id: number = 0;
  deleted: boolean = false;

  constructor(
    private service: ContapagarService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params.id;
  }

  back(): void {
    this.router.navigate(['/contapagar']);
  }

  delete(): void {
    this.deleted = false;

    this.service.delete(this.id)
      .subscribe(
        response => {
          this.deleted = true;
        },
        error => {      
          this.router.navigate(['/contapagar']);
        });
  }

}
