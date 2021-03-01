import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContapagarListComponent } from './contapagar-list.component';

describe('ContapagarListComponent', () => {
  let component: ContapagarListComponent;
  let fixture: ComponentFixture<ContapagarListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ContapagarListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ContapagarListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
