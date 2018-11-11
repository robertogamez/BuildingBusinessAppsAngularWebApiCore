import { Show } from "./show.model";
import { TourWithEstimatedProfits } from "../../shared/tour-with-estimated-profits.model";

export class TourWithEstimatedProfitsAndShows extends TourWithEstimatedProfits {
    shows: Show[];
}
